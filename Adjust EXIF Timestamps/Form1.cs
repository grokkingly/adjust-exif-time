using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Collections.Generic;

namespace AdjustEXIFTimestamps
{
    public partial class AdjustEXIFTimestamps : Form
    {
        
        private StatusInfo statusInfo;

        class FileStatus
        {
            public bool Success;
            string File;
            string Message;

            public FileStatus(bool success)
                : this(success, "")
            { }
            public FileStatus(bool success, string file)
                : this(success, file, "")
            { }

            public FileStatus(bool success, string file, string message)
            {
                Success = success;
                File = file;
                Message = message;
            }
        }

        class StatusInfo
        {
            public List<FileStatus> fileList;

            public StatusInfo()
            {
                fileList = new List<FileStatus>();
            }

            public void fileFail(string fileName)
            {
                fileFail(fileName, "");
            }

            public void fileFail(string fileName, string message)
            {
                addStatus(false, fileName, message);
            }

            public void fileSuccess(string fileName)
            {
                addStatus(true, fileName, "");
            }

            private void addStatus(bool status, string fileName, string message)
            { 
                fileList.Add(new FileStatus(status, fileName, message));
            }

            public bool Success
            {
                get
                {
                    bool tempSuccess = true;
              
                    foreach (FileStatus tempStatus in fileList)
                    {
                        tempSuccess = tempSuccess & tempStatus.Success;
                    }
               
                    return tempSuccess;
                }
            }
        }
        
        private void ToggleHelp()
        {
            HelpPanel.Visible = !HelpPanel.Visible;
            if (HelpPanel.Visible)
                HelpPanel.BringToFront();
            else
                HelpPanel.BringToFront();
        }

        protected void ClearForm()
        {
            textBoxSource.Text = "";
            comboBoxImages.Items.Clear();
            currentDateTaken.Text = "";
            newDateTaken.Text = "";
            textBoxTarget.Text = "";
         }

        protected bool ValidateInput()
        {
            if (textBoxSource.Text == "") throw new ApplicationException("Select the folder that contains the pictures");
            if (textBoxTarget.Text == "") throw new ApplicationException("Select the folder where the modified pictures will be saved");
            if (textBoxSource.Text == textBoxTarget.Text) throw new ApplicationException("Select destination folder other than the source folder");
            if (comboBoxImages.SelectedIndex == -1) throw new ApplicationException("Select sample file");
            if (newDateTaken.Text == "") throw new ApplicationException("Enter New Date Taken");
            if (newDateTaken.Text == currentDateTaken.Text) throw new ApplicationException("New Date Taken is same as Current Date Taken");
            return true;
        }

        protected void DisableControls()
        {
            buttonSource.Enabled = false;
            buttonDestination.Enabled = false;
            newDateTaken.Enabled = false;
            buttonGo.Enabled = false;
            comboBoxImages.Enabled = false;
            textBoxSource.Enabled = false;
            textBoxTarget.Enabled = false;
            currentDateTaken.Enabled = false;
        }
        
        protected bool SelectSourceFolder()
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.ShowNewFolderButton = false;
            folderDialog.Description = "Select the folder containing the pictures with incorrect EXIF dates";
            if (folderDialog.ShowDialog() == DialogResult.Cancel) return false;
            textBoxSource.Text = folderDialog.SelectedPath;
            return true;
        }

        protected bool SelectTargetFolder()
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.ShowNewFolderButton = true;
            folderDialog.SelectedPath = textBoxSource.Text;
            folderDialog.Description = "Select the folder, where the pictures with modified EXIF date & time will be saved";
            if (folderDialog.ShowDialog() == DialogResult.Cancel) return false;
            textBoxTarget.Text = folderDialog.SelectedPath;
            return true;
        }

        /// <summary>
        /// Lists all files from the selected folder
        /// </summary>
        protected void showImages()
        {
            DirectoryInfo sourceFolder = new DirectoryInfo(textBoxSource.Text);
            if (!sourceFolder.Exists) throw new DirectoryNotFoundException("Folder does not exist!");

            foreach (FileInfo nextFile in sourceFolder.GetFiles())
            {
                comboBoxImages.Items.Add(nextFile.Name);
            }
        }
                
        public AdjustEXIFTimestamps()
        {
            InitializeComponent();
        }
    
        /// <summary>
        /// Displays the selected picture in the image area
        /// also displays the picture file name and Date Taken EXIF property
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnComboBoxImagesSelectedIndexChanged(object sender, EventArgs e)
        {
            TimeSpan timeShift = new TimeSpan();
            bool preview;
                if (comboBoxImages.SelectedIndex == -1) return;
                try
                {
                    //todo - using TryParse?
                    timeShift = DateTime.ParseExact(newDateTaken.Text, "yyyy:MM:dd HH:mm:ss", null) - DateTime.ParseExact(currentDateTaken.Text, "yyyy:MM:dd HH:mm:ss", null);
                    preview = true;
                }
                catch
                { preview = false; }

                string selectedFile = comboBoxImages.Items[comboBoxImages.SelectedIndex].ToString();
                string filePath = Path.Combine(textBoxSource.Text, selectedFile);
                Image photo;
                try
                {
                    photo = new Bitmap(filePath);
                    PropertyItem dateTimeShot = photo.GetPropertyItem(36867);
                    ASCIIEncoding encoding = new ASCIIEncoding();
                    string whenShot = encoding.GetString(dateTimeShot.Value);
                    whenShot = whenShot.Remove(19);
                    currentDateTaken.Text = whenShot;
                    if (preview)
                    {
                        DateTime tempDateTime = DateTime.ParseExact(whenShot, "yyyy:MM:dd HH:mm:ss", null);
                        tempDateTime += timeShift;
                        newDateTaken.Text = tempDateTime.ToString("yyyy:MM:dd HH:mm:ss");
                    }
                    else
                    {
                        newDateTaken.Text = whenShot;
                    }
                    pictureBoxSelected.ImageLocation = filePath;
                    pictureBoxSelected.SizeMode = PictureBoxSizeMode.Zoom;
                    photo.Dispose();
                }
                catch
                {
                    currentDateTaken.Text = "";
                    newDateTaken.Text = "";
                    pictureBoxSelected.ImageLocation = "";
                    MessageBox.Show("Could not read EXIF data from " + selectedFile);
                }
         }

        private void AddNewStatus(string status)
        {
            textBoxStatus.AppendText("\r\n" + status);
        }
        private void AddStatus(string status)
        {
            textBoxStatus.AppendText(status);
        }

        /// <summary>
        /// Parses the new Date Taken, calculates the period to use when adjusting the times
        /// then calls ShiftSinglePictureTimes upon each image
        /// </summary>
        private void ShiftAllPicturesTimes()
        {
            string fullFileName;
            TimeSpan timeShift;

            progressBar.Minimum = 0;
            progressBar.Maximum = comboBoxImages.Items.Count;

            string selectedName = comboBoxImages.Items[comboBoxImages.SelectedIndex].ToString();
            selectedName = Path.Combine(textBoxSource.Text, selectedName);
            FileInfo selectedFile = new FileInfo(selectedName);

            string newDate = newDateTaken.Text;

            AddNewStatus("Calculating period... ");
            DateTime newDt;
            try
            {
                newDt = DateTime.ParseExact(newDate, "yyyy:MM:dd HH:mm:ss", null);
            }
            catch (FormatException ex)
            {
                throw new DateTimeFormatException("New Date Taken (" + newDate + ") is incorrect!", ex);
            }

            timeShift = newDt - DateTime.ParseExact(currentDateTaken.Text, "yyyy:MM:dd HH:mm:ss", null);
            //AddStatus(" " + timeShift.Days.ToString() + " days, " + timeShift.Hours.ToString() + " hours, " + timeShift.Minutes.ToString() + " minutes, and " + timeShift.Seconds.ToString() + " seconds");

            AddNewStatus("Modifying EXIF date & times... ");
            string newFileName;
            foreach (string nextFileName in comboBoxImages.Items)
            {
                progressBar.Value++;
                AddNewStatus(nextFileName + " - ");
                fullFileName = Path.Combine(textBoxSource.Text, nextFileName);
                newFileName = Path.Combine(textBoxTarget.Text, nextFileName);
                try
                {
                    ShiftSinglePictureTimes(fullFileName, newFileName, timeShift);
                    statusInfo.fileSuccess(fullFileName);
                    AddStatus(" - OK");
                }
                catch (Exception ex)
                {
                    statusInfo.fileFail(fullFileName, ex.Message);
                    AddStatus("FAILED");
                }
            }

            AddNewStatus("");
            if (statusInfo.Success)
            {
                AddNewStatus("Congratulations! All work is done.");
            }
            else
            {
                AddNewStatus("Done, but failed to update some pictures!");
            }
            AddNewStatus("");
            AddNewStatus("(Double-click on the status log to copy it to the clipboard)");
  
        }

        /// <summary>
        /// Creates Image object from fullFilePath,
        /// adjusts the time in EXIF items 36867 (Date Taken) and 36868 (Date Created) with timeShift
        /// and saves the Image object to saveFilePath
        /// </summary>
        /// <param name="fullFilePath"></param>
        /// <param name="saveFilePath"></param>
        /// <param name="timeShift"></param>
        private void ShiftSinglePictureTimes(string fullFilePath, string saveFilePath, TimeSpan timeShift)
        {
                Image photo = new Bitmap(fullFilePath);
                try
                {
                    ShiftPropItemDateTime(photo, 36867, timeShift, true);
                    ShiftPropItemDateTime(photo, 36868, timeShift, false);

                    photo.Save(saveFilePath);
                }
                finally
                {
                    photo.Dispose();
                }
        }

        /// <summary>
        /// Adjusts the Date/Time of PropertyItem propDecId in Image photo with period timeShift
        /// </summary>
        /// <param name="photo"></param>
        /// <param name="propDecId"></param>
        /// <param name="timeShift"></param>
        private void ShiftPropItemDateTime(Image photo, int propDecId, TimeSpan timeShift, bool updateLog)
        {
            PropertyItem dateTimeItem = photo.GetPropertyItem(propDecId);
    
            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
            
            string dateAsString = encoding.GetString(dateTimeItem.Value);
            dateAsString = dateAsString.Remove(19);
            DateTime tempDateTime = DateTime.ParseExact(dateAsString, "yyyy:MM:dd HH:mm:ss", null);
            tempDateTime += timeShift;
            dateAsString = tempDateTime.ToString("yyyy:MM:dd HH:mm:ss");
            if (updateLog) AddStatus(dateAsString);
            dateAsString += "\0";
            dateTimeItem.Value = encoding.GetBytes(dateAsString);
            photo.SetPropertyItem(dateTimeItem);
        }

        /// <summary>
        /// Processes the pictures in the selected folder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnButtonGoClick(object sender, EventArgs e)
        {
            statusInfo = new StatusInfo();
            textBoxStatus.Visible = true;
            textBoxStatus.Text = "";

            try
            {
                AddNewStatus("Validating input... ");
                ValidateInput();
                if (MessageBox.Show("If you're happy with the settings, press OK to continue", "Modify EXIF time stamps", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    ShiftAllPicturesTimes();
                    DisableControls();
                }
                else
                { textBoxStatus.Text = ""; }

               /*
                string targetFolder = textBoxTarget.Text;
                int selectedFileIndex = comboBoxImages.SelectedIndex;
                ClearForm();
                AddNewStatus("Displaying modified pictures... ");
                textBoxSource.Text = targetFolder;
                showImages();
                comboBoxImages.SelectedIndex = selectedFileIndex;
                 */
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OnButtonSourceClick(object sender, EventArgs e)
        {
            try
            {
               ClearForm();
               if (SelectSourceFolder())
               {
                   showImages();
                   comboBoxImages.SelectedIndex = 0;
               }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OnButtonCloseClick(object sender, EventArgs e)
        {
            Close();
        }

        private void OnButtonTargetClick(object sender, EventArgs e)
        {
            SelectTargetFolder();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ToggleHelp();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToggleHelp();
        }

        private void textBoxStatus_DoubleClick(object sender, EventArgs e)
        {
            if (textBoxStatus.Text == "")
            {
                MessageBox.Show("No text to copy!");
            }
            else
            {
                Clipboard.SetText(textBoxStatus.Text);
                textBoxStatus.DeselectAll();
                MessageBox.Show("Change log copied to clipboard");
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://github.com/grokkingly/Adjust-EXIF-Timestamps");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void HelpPanel_Paint(object sender, PaintEventArgs e)
        {

        }

    }


    class DateTimeFormatException : FormatException
    {
        public DateTimeFormatException(string message)
            : this(message, null)
        {
        }

        public DateTimeFormatException(string message, FormatException ex)
            : base(message, ex)
        { 
        }
    }



}

namespace AdjustEXIFTimestamps
{
    partial class AdjustEXIFTimestamps
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdjustEXIFTimestamps));
            this.pictureBoxSelected = new System.Windows.Forms.PictureBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonGo = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxTarget = new System.Windows.Forms.TextBox();
            this.buttonDestination = new System.Windows.Forms.Button();
            this.newDateTaken = new System.Windows.Forms.TextBox();
            this.currentDateTaken = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBoxImages = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonSource = new System.Windows.Forms.Button();
            this.textBoxSource = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.HelpPanel = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelected)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.HelpPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxSelected
            // 
            this.pictureBoxSelected.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxSelected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxSelected.Location = new System.Drawing.Point(3, 16);
            this.pictureBoxSelected.Name = "pictureBoxSelected";
            this.pictureBoxSelected.Size = new System.Drawing.Size(271, 183);
            this.pictureBoxSelected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxSelected.TabIndex = 19;
            this.pictureBoxSelected.TabStop = false;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxStatus.Location = new System.Drawing.Point(5, 19);
            this.textBoxStatus.Multiline = true;
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.ReadOnly = true;
            this.textBoxStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxStatus.Size = new System.Drawing.Size(585, 114);
            this.textBoxStatus.TabIndex = 20;
            this.textBoxStatus.TabStop = false;
            this.toolTip1.SetToolTip(this.textBoxStatus, "Double-click to copy change log to clipboard");
            this.textBoxStatus.DoubleClick += new System.EventHandler(this.textBoxStatus_DoubleClick);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(5, 139);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(585, 22);
            this.progressBar.TabIndex = 100;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(622, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.Location = new System.Drawing.Point(549, 222);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(60, 40);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.OnButtonCloseClick);
            // 
            // buttonGo
            // 
            this.buttonGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonGo.Location = new System.Drawing.Point(332, 222);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(211, 40);
            this.buttonGo.TabIndex = 6;
            this.buttonGo.Text = "Modify the EXIF time stamps";
            this.toolTip1.SetToolTip(this.buttonGo, "The time stamps of all pictures in the source folder will be adjusted with the di" +
                    "fference between the sample picture\'s new and old time stamps");
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.OnButtonGoClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxTarget);
            this.groupBox4.Controls.Add(this.buttonDestination);
            this.groupBox4.Location = new System.Drawing.Point(12, 217);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(308, 45);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Save the modified pictures here";
            // 
            // textBoxTarget
            // 
            this.textBoxTarget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTarget.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTarget.Location = new System.Drawing.Point(29, 16);
            this.textBoxTarget.Name = "textBoxTarget";
            this.textBoxTarget.Size = new System.Drawing.Size(274, 20);
            this.textBoxTarget.TabIndex = 100;
            this.textBoxTarget.TabStop = false;
            this.toolTip1.SetToolTip(this.textBoxTarget, "Press button to select target folder");
            // 
            // buttonDestination
            // 
            this.buttonDestination.Location = new System.Drawing.Point(6, 15);
            this.buttonDestination.Name = "buttonDestination";
            this.buttonDestination.Size = new System.Drawing.Size(20, 20);
            this.buttonDestination.TabIndex = 4;
            this.toolTip1.SetToolTip(this.buttonDestination, "Press to select target folder");
            this.buttonDestination.UseVisualStyleBackColor = true;
            this.buttonDestination.Click += new System.EventHandler(this.OnButtonTargetClick);
            // 
            // newDateTaken
            // 
            this.newDateTaken.Location = new System.Drawing.Point(172, 61);
            this.newDateTaken.Name = "newDateTaken";
            this.newDateTaken.Size = new System.Drawing.Size(130, 20);
            this.newDateTaken.TabIndex = 3;
            this.toolTip1.SetToolTip(this.newDateTaken, "New timestamp in format yyyy:mm:dd hh:mm:ss with hours between 00 and 23");
            // 
            // currentDateTaken
            // 
            this.currentDateTaken.Location = new System.Drawing.Point(28, 61);
            this.currentDateTaken.Name = "currentDateTaken";
            this.currentDateTaken.ReadOnly = true;
            this.currentDateTaken.Size = new System.Drawing.Size(131, 20);
            this.currentDateTaken.TabIndex = 100;
            this.currentDateTaken.TabStop = false;
            this.toolTip1.SetToolTip(this.currentDateTaken, "Current timestamp");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(169, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Change to / Preview";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(26, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Currently";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.newDateTaken);
            this.groupBox2.Controls.Add(this.currentDateTaken);
            this.groupBox2.Controls.Add(this.comboBoxImages);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 107);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "...and I know the correct date and time for this one";
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox4.Location = new System.Drawing.Point(28, 87);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(274, 14);
            this.textBox4.TabIndex = 101;
            this.textBox4.Text = "Scroll through the pictures to preview the changes";
            // 
            // comboBoxImages
            // 
            this.comboBoxImages.FormattingEnabled = true;
            this.comboBoxImages.Location = new System.Drawing.Point(28, 19);
            this.comboBoxImages.Name = "comboBoxImages";
            this.comboBoxImages.Size = new System.Drawing.Size(274, 21);
            this.comboBoxImages.TabIndex = 6;
            this.comboBoxImages.SelectedIndexChanged += new System.EventHandler(this.OnComboBoxImagesSelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.buttonSource);
            this.groupBox3.Controls.Add(this.textBoxSource);
            this.groupBox3.Location = new System.Drawing.Point(12, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(308, 90);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "The pictures with incorrect EXIF timestamps are here...";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox3.Location = new System.Drawing.Point(28, 43);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(274, 41);
            this.textBox3.TabIndex = 102;
            this.textBox3.Text = "The EXIF time stamps of all pictures in the selected folder will be adjusted with" +
                " the same time difference. The modified pictures will be saved in the destinatio" +
                "n folder.";
            // 
            // buttonSource
            // 
            this.buttonSource.Location = new System.Drawing.Point(6, 17);
            this.buttonSource.Name = "buttonSource";
            this.buttonSource.Size = new System.Drawing.Size(20, 20);
            this.buttonSource.TabIndex = 1;
            this.toolTip1.SetToolTip(this.buttonSource, "Press to select source folder");
            this.buttonSource.UseVisualStyleBackColor = true;
            this.buttonSource.Click += new System.EventHandler(this.OnButtonSourceClick);
            // 
            // textBoxSource
            // 
            this.textBoxSource.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxSource.Location = new System.Drawing.Point(28, 17);
            this.textBoxSource.Name = "textBoxSource";
            this.textBoxSource.ReadOnly = true;
            this.textBoxSource.Size = new System.Drawing.Size(274, 20);
            this.textBoxSource.TabIndex = 100;
            this.textBoxSource.TabStop = false;
            this.toolTip1.SetToolTip(this.textBoxSource, "Press button to select source folder");
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.progressBar);
            this.groupBox8.Controls.Add(this.textBoxStatus);
            this.groupBox8.Location = new System.Drawing.Point(13, 268);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(596, 170);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Progress";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.pictureBoxSelected);
            this.groupBox7.Location = new System.Drawing.Point(332, 9);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(277, 202);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Picture preview";
            // 
            // HelpPanel
            // 
            this.HelpPanel.BackColor = System.Drawing.SystemColors.Window;
            this.HelpPanel.Controls.Add(this.linkLabel2);
            this.HelpPanel.Controls.Add(this.button1);
            this.HelpPanel.Controls.Add(this.textBox1);
            this.HelpPanel.Location = new System.Drawing.Point(0, 27);
            this.HelpPanel.Name = "HelpPanel";
            this.HelpPanel.Size = new System.Drawing.Size(622, 450);
            this.HelpPanel.TabIndex = 27;
            this.HelpPanel.Visible = false;
            this.HelpPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.HelpPanel_Paint);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(34, 313);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(231, 13);
            this.linkLabel2.TabIndex = 5;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "github.com/grokkingly/Adjust-EXIF-Timestamps";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(276, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(37, 29);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(546, 281);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonGo);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox8);
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox7);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 450);
            this.panel1.TabIndex = 28;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.ReshowDelay = 100;
            // 
            // AdjustEXIFTimestamps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(622, 477);
            this.Controls.Add(this.HelpPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "AdjustEXIFTimestamps";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Adjust EXIF Timestamps";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelected)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.HelpPanel.ResumeLayout(false);
            this.HelpPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSelected;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel HelpPanel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxTarget;
        private System.Windows.Forms.Button buttonDestination;
        private System.Windows.Forms.TextBox newDateTaken;
        private System.Windows.Forms.TextBox currentDateTaken;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonSource;
        private System.Windows.Forms.TextBox textBoxSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBoxImages;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.LinkLabel linkLabel2;
        }
}


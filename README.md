This is a personal project solving a problem I get every now and then - a bunch of pictures with incorrect EXIF timestamps that need to be changed to allow for proper merging with other pictures (e.g. - from friends).  Happens when traveling to other time zones, forgetting to change DST in the camera, leaving the battery out for too long, etc. There are many other programs capable of batch correction of EXIF time-stamps; I coded this to practice while studying .NET/C#.

It was designed to make use of the easiest way to get a record of the accurate time - taking a picture of a clock. In that picture you'll have the correct time (the image of the clock) and the incorrect EXIF timestamp. It's important that you take that picture before making changes to the camera's date & time settings.

To use, simply point the program to the folder containing your images, select the picture with known correct time (e.g. the one of the clock) and enter the accurate date and time for that picture. Based on your input, the program calculates and lets you preview the resulting date and time for the other pictures. When happy with the preview, hit 'Modify the EXIF time stamps'. Both 'DateTimeOriginal' and 'DateTimeDigitized' will be changed. Copies of the pictures are modified and saved to a separate folder, the originals remain intact.

Note that the time is in 24-hour format, NOT AM/PM.

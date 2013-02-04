# A .NET WinForms app for fixing incorrect picture time-stamps

## tl;dr
Adjusts the time-stamps of your pictures. Just point to one of the pictures and enter its correct date & time. Having taken a pictue of a clock helps greatly.

## More
This is a personal project solving a problem I get every now and then - a bunch of pictures with incorrect EXIF timestamps that need to be changed to allow for proper merging with other pictures (e.g. - from friends). Happens when traveling to other time zones, forgetting to change DST in the camera, leaving the battery out for too long, etc. While there are other programs capable of batch correction of EXIF time-stamps I decided to code this single-purpose app myself.

It was designed to make use of the easiest way to get a record of the accurate time - taking a picture of a clock. In that picture you'll have the correct time (the image of the clock) and the incorrect EXIF timestamp. It's important that you take that picture *before* fixing the camera's date & time setting.

## How-to:
1. Point the program to the folder containing your images.
2. Select the picture with known correct time.
3. Enter the accurate date and time for that picture.
4. Based on your input, the program calculates and lets you preview the resulting date and time for the other pictures.
5. When happy with the preview, hit *'Modify the EXIF time stamps'*.

## Notes
- Both `DateTimeOriginal` and `DateTimeDigitized` will be adjusted.
- The pictures with corrected date & time are saved in a separate folder. The originals remain intact.
- The time is in 24-hour format.

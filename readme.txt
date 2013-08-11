Readme

Hi,

This is a simple window application written by a student who always faced the problem of wrong ID3 tag.
With this simple application, you can rename songs in the same folder to desired ID3 tag.

Parameters needed: (* notify it is mandatory)

1.	Song Folder* 
The folder that contains songs that you would like to change their ID3 tag

example:
H:\MUSIC\CLASSIC\Walter Gieseking - Debussy - The Complete Works for Piano - MP3 VBR0\


2.	Song Name Text File Path*
The .txt file that contains lines of song names that will be used to replace the old ID3 title.
Important: Text file using Unicode to encode is highly recommend!
For example, a text file with three lines, first line is 'A', second is 'B' and third is 'C'.
That means update the first song to 'A', second to 'B' and third to 'C'.

example:
H:\MUSIC\CLASSIC\Walter Gieseking - Debussy - The Complete Works for Piano - MP3 VBR0\songname.txt


3.	Author
The updated name of author, empty implies no changes should be made

example:
Debussy


4.	Album
The updated name of album, empty implies no changes should be made

example:
The Complete Works for Piano


5.	Song File Format
The file format of the targeted songs

example:
mp3


6. Preview Result
If not checked, the targeted change will be applied to the targeted song.
If checked, the targeted change will not be applied to the targeted song but only a preview of update will be outputed to the textarea.

regards,
Leah

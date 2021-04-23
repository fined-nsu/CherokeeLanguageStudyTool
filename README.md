# Cherokee Language Study Tool
 An application to assist with studying the Cherokee language.

### Description
This application contains two primary modules each consisting of a practice mode and an assessment mode. The primary goal of this application is to assist in learning the Cherokee language in the Phonetic and Syllabary forms. Methods used include word lists displaying English, Phonetic, and Syllabary translations as well as matching Phonetic syllables to the corresponding Syllabary glyph. After spending time with the practice modes an assessment can be completed to measure performance. A record keeping system is in place to allow viewing assessment performance metrics over time. This includes the top score, previous performance score, and number of attempts for each assessment.

## Table of Contents
1. [Installation][README Installation Header]
2. [Setting up for development][README Dev Setup Header]
3. [Technology][README Technology Header]
3. [Instructions][README Instructions Header]
4. [License][README License Header]

### Installation
A standalone and installable version of the application are available in the following Google Drive shared folder:
[Google Drive shared folder][Google Drive]

The standalone version is contained in the compressed file **Cherokee Language Learning Tool.zip**. Upon decompressing the file you will find an executable named **CherokeeStudyTool.exe**. Executing this file will launch the application. *The Resources and Records folders must remain in the same folder as the executable in order for the application to function properly*.

The installable version of the application is available as **LanguageToolSetup.msi**. Using this file will install the application within **C:\Program Files (x86)** and place the Resources and Records folders in **C:\ProgramData\Fine Software**, create an entry in the start menu, and create a desktop shortcut. *Having the Resources and Records folders in ProgramData allows standard user profiles to have the necessary rights to access and write files to these folders*.

The application can be uninstalled through the typical process such as the Add/Remove Programs Control Panel.

A readme file is also included with some brief information about the program.

### Setting up for development
For instructions cloning the project directly within Visual Studio 2019 see these instructions from Microsoft: [Open a project from a repo](https://docs.microsoft.com/en-us/visualstudio/get-started/tutorial-open-project-from-repo-visual-studio-2019?view=vs-2019&tabs=vs168later)

##### Within GitHub Desktop the repository can be cloned using the following steps:
1. Select File
2. Select Clone Repository...
3. Select the URL tab
4. Enter https://github.com/fined-nsu/CherokeeLanguageStudyTool
5. Choose a local path to save the repository on your computer
6. Select the Clone button

Alternatively [download the project zip file][Project ZIP file] and decompress it. Locate the solution file CherokeeStudyTool.sln within the decompressed folder and open it with Visual Studio.

##### You might encounter one of the following errors:

* Severity Code Description Project File Line Suppression State Error Couldn't process file PhoneticPracticeForm.resx due to its being in the Internet or Restricted zone or having the mark of the web on the file.
Remove the mark of the web if you want to process these files.

* CherokeeStudyTool Couldn't process file PhoneticPracticeForm.resx due to its being in the Internet or Restricted zone or having the mark of the web on the file.
Remove the mark of the web if you want to process these files.

##### To address this issue:
1. Navigate to the **PhoneticPracticeForm.resx** file within the project folder structure (e.g. C:\Users\\*username*\Downloads\CherokeeLanguageStudyTool-main\CherokeeStudyTool\PhoneticPracticeForm.resx where username is replaced with the actual user profile name)
2. **Right-click** on the **PhoneticPracticeForm.resx** file and left-click **Properties**.
3. At the bottom of the Properties window look for a message with an **Unblock checkbox**.
4. **Click the checkbox** to unblock the file.
5. Click **OK** to save the change and close the file Properties.
6. Attempt to run the project again.

If you receive the same message with a different file name repeat the process but substitute the file specified in the error.

Unblocking the file removes the mark of the web from the file. This is a safety measure implemented by Microsoft Windows. Unfortunately this is not something that cannot be addressed within the code, and must be performed on the end user's computer.

### Technology
This application was developed using C# and .NET Framework 4.7.2. The user interface was created using Windows Forms. Microsoft Windows Media Player has been incorporated to allow playing audio files. This required installing the Windows SDK and adding wmplib.dll to the Visual Studio toolbox as a custom control. More info can be found [here](https://docs.microsoft.com/en-us/windows/win32/wmp/using-the-windows-media-player-control-with-microsoft-visual-studio).

 The following excerpt from the code shows how the Windows Media Player control was implemented in the Phonetic Practice mode to play sound files from the Cherokee Language program website:

```C#
private void PlayCherokeeAudio(object sender, EventArgs e)
        {
            // Requires wmplib. Info available at https://docs.microsoft.com/en-us/windows/win32/wmp/using-the-windows-media-player-control-with-microsoft-visual-studio.

            ListBox lb = sender as ListBox;
            if (lb.SelectedItem == null)
            {
                return;
            }

            WindowsMediaPlayer player = new WindowsMediaPlayer(); // Creates a new media player.
            if (lb.SelectedIndex < CherokeeWordList.Count) // Checks whether selected index is in range to prevent errors with improper word list formatting.
            {
                string wordString = CherokeeWordList[lb.SelectedIndex].English;     // Assigns the string stored at the selected listbox index.
                player.URL = @"https://data.cherokee.org/Cherokee/LexiconSoundFiles/" + wordString + ".mp3";    // Creates a URL to the audio file on the Cherokee Language website.


                try   // Attempts to play the audio file if it exists.
                {
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(player.URL);
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                    if (response.StatusCode == HttpStatusCode.OK)  // If the site returns a status of OK then the file is played.
                    {
                        player.controls.play(); //Plays the audio.
                        lblAudioStatus.Visible = false; //Hides the audio status label if audio is playing.
                    }

                    response.Close();
                }
                catch (WebException ex)     // If the audio file doesn't exist a message is sent to the audio status label to tell the user the file is unavailable.
                {
                    if (ex.Status == WebExceptionStatus.ProtocolError && ex.Response != null)   //Checks if an error message is received and the respsonse is not null.
                    {
                        var resp = (HttpWebResponse)ex.Response;    //Assigns the exception response as an HttpWebResponse message.
                        if (resp.StatusCode == HttpStatusCode.NotFound) //If the response code indicates the resource isn't found a message is assigned to the audio status label to indicate the audio is unavailable.
                        {
                            lblAudioStatus.Text = "Audio Unavailable for " + CherokeeWordList[lb.SelectedIndex].English;    //The file name is included with the message.
                            lblAudioStatus.Visible = true;  //The label is set to visible.
                        }
                    }
                    else
                    { throw; }
                }
            }
            else
            {
                lblAudioStatus.Text = "Word list formatting error before line " + (lb.SelectedIndex + 1); //Provide error information if selected index is out of range due to improper word list formatting.
            }
        }

```


### Instructions
This application focuses on learning the Cherokee language in two parts. The first part is the Phonetic and the second is the Syllabary. Each part has a practice mode and an assessment.

Upon starting the application the Main Menu loads with two textboxes, one each for the user's first and last names. These are used for tracking performance in the assessments. If no name is entered the performance will not be recorded. The Main Menu also presents four options to choose from: Phonetic Practice, Phonetic Assessment, Syllabary Practice, and Syllabary Assessment. Each option is available via the buttons located near the center.

![Main Menu]

 The option to view previously created records is available via the File menu View Records option, or by clicking the View Records button below the username textboxes. If a user record exists the information for each mode will be presented.

![Records Found]

If a user record does not exist matching the entered name a message will display stating that the record doesn't exist.

![Records Not Found]

The Phonetic practice mode allows unlimited time to study English to Phonetic translation. Several word lists have been included along with support for importing user created lists. Each word list has the English, Phonetic, and Syllabary translation of the word displayed separately. When clicking on a word an audio file is played, if available, demonstrating the pronunciation in Cherokee.

![Phonetic Practice]

The Phonetic assessment mode provides a way to test your learning progress through a timed translation exercise. By default the words are displayed in Cherokee Phonetic and the English translation is entered into the textbox next to the word. Optionally the translation can be reversed with the English word listed and the Phonetic word entered into the textbox. Phonetic word entry can be done with or without spaces or hyphens separating each syllable. Each correct translation awards one point. The assessment has a timer with five minutes and thirty seconds which starts counting down when the Begin Round button is clicked. The round ends when the timer reaches zero seconds remaining or the user clicks the End Round button. The top score for the user can be saved as long as the name was entered on the main menu before beginning the assessment round.

Instructions for creating new word lists are contained in [WordListCreation.md][Word List Creation] which can be found in the [Documentation][Documentation Folder] folder.

![Phonetic Assessment]

The Syllabary practice mode allows the user to enter Phonetic syllables into any of the eight textboxes and see the corresponding Syllabary glyph displayed above the textbox. This mode is untimed and each textbox can be changed to allow another Syllabary glyph image to be displayed. Images are only displayed if the entered Phonetic text matches a Syllabary glyph and the image disappears if the text is changed to something that does not match.

![Syllabary Practice]

The Syllabary assessment mode presents Syllabary glyph images and allows the user to enter text into the textbox below each image. Upon matching the correct Phonetic syllable to the displayed image the user is awarded one point and a new image is loaded. The assessment begins with five minutes and thirty seconds on the timer and continues until the timer has reached zero seconds remaining. The user can also click the End Round button to stop early. The top score for the user can be saved as long as a name was entered on the main menu before beginning the assessment round.

![Syllabary Assessment]



### License
Using the MIT License - See [LICENSE][LICENSE]

[Google Drive]: https://drive.google.com/drive/folders/1NJnJqUv1bzFtUIZ1-yjPH09sDGkvy0zn?usp=sharing
[README Installation Header]: https://github.com/fined-nsu/CherokeeLanguageStudyTool/blob/main/README.md#installation
[README Dev Setup Header]: https://github.com/fined-nsu/CherokeeLanguageStudyTool/blob/main/README.md#setting-up-for-development
[README Technology Header]: https://github.com/fined-nsu/CherokeeLanguageStudyTool/blob/main/README.md#Technology
[README Instructions Header]: https://github.com/fined-nsu/CherokeeLanguageStudyTool/blob/main/README.md#Instructions
[README License Header]: https://github.com/fined-nsu/CherokeeLanguageStudyTool/blob/main/README.md#License
[LICENSE]: https://github.com/fined-nsu/CherokeeLanguageStudyTool/blob/main/Licensing/LICENSE
[Project ZIP file]: https://github.com/fined-nsu/CherokeeLanguageStudyTool/archive/refs/heads/main.zip
[Main Menu]: https://github.com/fined-nsu/CherokeeLanguageStudyTool/blob/main/misc/MainMenu.png
[Phonetic Practice]: https://github.com/fined-nsu/CherokeeLanguageStudyTool/blob/main//misc/PhoneticPractice.gif
[Phonetic Assessment]: https://github.com/fined-nsu/CherokeeLanguageStudyTool/blob/main/misc/PhoneticAssessment.gif
[Syllabary Practice]: https://github.com/fined-nsu/CherokeeLanguageStudyTool/blob/main/misc/SyllabaryPractice.gif
[Syllabary Assessment]: https://github.com/fined-nsu/CherokeeLanguageStudyTool/blob/main/misc/SyllabaryAssessment.gif
[Records Found]: https://github.com/fined-nsu/CherokeeLanguageStudyTool/blob/main/misc/RecordsFound.png
[Records Not Found]: https://github.com/fined-nsu/CherokeeLanguageStudyTool/blob/main/misc/RecordsNotFound.png
[Documentation Folder]: https://github.com/fined-nsu/CherokeeLanguageStudyTool/tree/main/Documentation
[Word List Creation]: https://github.com/fined-nsu/CherokeeLanguageStudyTool/tree/main/Documentation/WordListCreation.md

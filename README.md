# Cherokee Language Study Tool
 An application to assist with studying the Cherokee language.

### Description
This application contains two primary modules each consisting of a practice mode and an assessment mode.

## Table of Contents
1. [Installation][README Installation Header]
2. [Setting up for development][README Dev Setup Header]
2. [Usage][README Usage Header]
3. [Instructions][README Instructions Header]
4. [License][README License Header]

### Installation
A standalone and installable version of the application are available in the following Google Drive shared folder:
[Google Drive shared folder][Google Drive]

The standalone version is contained in the compressed file Cherokee Language Learning Tool.zip. Upon decompressing the file you will find an executable named CherokeeStudyTool.exe. Executing this file will launch the application. The Resources and Records folders must remain in the same folder as the executable in order for the application to function properly.

The installable version of the application is available as LanguageToolSetup.msi. Using this file will install the application in C:\ProgramFiles(x86) and place the Resources and Records folders in C:\ProgramData, create an entry in the start menu, and create a desktop shortcut. Having the Resources and Records folders in ProgramData allows standard user profiles the needed rights to access and write files to these folders. The application can be uninstalled through the typical process such as the Add/Remove Programs Control Panel.

A readme file is also included with some brief information about the program.

### Setting up for development
Clone the repository or [download the project zip file][Project ZIP file].

### Usage

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
[README Usage Header]: https://github.com/fined-nsu/CherokeeLanguageStudyTool/blob/main/README.md#Usage
[README Instructions Header]: https://github.com/fined-nsu/CherokeeLanguageStudyTool/blob/main/README.md#Instructions
[README License Header]: https://github.com/fined-nsu/CherokeeLanguageStudyTool/blob/main/README.md#License
[LICENSE]: https://github.com/fined-nsu/CherokeeLanguageStudyTool/blob/main/Licensing/LICENSE
[Project ZIP file]: https://github.com/fined-nsu/CherokeeLanguageStudyTool/archive/refs/heads/main.zip
[Main Menu]: https://github.com/fined-nsu/CherokeeLanguageStudyTool/blob/main/misc/MainMenu.png
[Phonetic Practice]: https://github.com/fined-nsu/CherokeeLanguageStudyTool/blob/main//misc/PhoneticPractice.png
[Phonetic Assessment]: https://github.com/fined-nsu/CherokeeLanguageStudyTool/blob/main/misc/PhoneticAssessment.png
[Syllabary Practice]: https://github.com/fined-nsu/CherokeeLanguageStudyTool/blob/main/misc/SyllabaryPractice.png
[Syllabary Assessment]: https://github.com/fined-nsu/CherokeeLanguageStudyTool/blob/main/misc/SyllabaryAssessment.png
[Records Found]: https://github.com/fined-nsu/CherokeeLanguageStudyTool/blob/main/misc/RecordsFound.png
[Records Not Found]: https://github.com/fined-nsu/CherokeeLanguageStudyTool/blob/main/misc/RecordsNotFound.png

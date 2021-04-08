using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;
using System.IO;
using WMPLib;

namespace CherokeeStudyTool
{
    public partial class PhoneticPracticeForm : Form
    {
        List<Cherokee> CherokeeWordList = new List<Cherokee>();
        string[] englishWords = new string[30];
        string[] phoneticWords = new string[30];
        string[] syllabaryWords = new string[30];


        public PhoneticPracticeForm()
        {
            InitializeComponent();
            LoadWordListsFromResources();
            ResetListBoxHeight();
        }

        /// <summary>
        /// A method to allow the import of new word lists for use in the applications. Imported lists are copied to the Resources folder in the applications ProgramData folder.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportNewList(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                ofd.Filter = "txt files (*.txt)|*.txt";
                

                if (ofd.ShowDialog() == DialogResult.OK)    //Checks if the file dialog returns OK. Skips if it returns Cancel.
                {
                    string filePath = ofd.FileName; //Stores the path of the user's file to import.
                    string fileName = filePath.Substring(ofd.InitialDirectory.Length + 1);  //Gets the filename.
                    string copyPath = Program.portableVersion ? Program.resourcesFolderLocationPortable + fileName : Program.resourcesFolderLocation + fileName;    //Stores the path for the applications Resource folder in ProgramData.
                    listBoxWordList.Items.Add(Path.GetFileNameWithoutExtension(filePath));  //The imported word list file name is added to the listbox so it can be used without reloading the form.
                    File.Copy(filePath, copyPath, true);    //The imported word list is copied so the user doesn't have to import each time.
                }
            }
        }

        /// <summary>
        /// Populates the listBox with available word lists from the applications Resources\WordLists folder.
        /// </summary>
        private void LoadWordListsFromResources()
        {
            string[] wordLists;
            if (Program.resourcesFoldersFound)
            {
                wordLists = Program.portableVersion ? Directory.GetFiles(Program.wordListsFolderLocationPortable, "*.txt") : Directory.GetFiles(Program.wordListsFolderLocation, "*.txt"); //Allows changing paths by just switching the boolean value for portableVersion.
            }
            else
            {
                wordLists = Directory.GetFiles(Properties.Settings.Default.customResourcesPath + @"WordLists\", "*.txt"); //Uses directory selected by user if the default locations are not present.
            }


            foreach (string wordlist in wordLists) //Iterates through each word list filename stored in the wordLists array.
            {
                string wordListName;
                if (Program.resourcesFoldersFound)
                {
                    wordListName = Program.portableVersion ? wordlist.Substring(Program.wordListsFolderLocationPortable.Length) : wordlist.Substring(Program.wordListsFolderLocation.Length);  //Creates a substring without the file path.
                }
                else
                {
                    wordListName = wordlist.Substring(Properties.Settings.Default.customResourcesPath.Length);
                }
                listBoxWordList.Items.Add(Path.GetFileNameWithoutExtension(wordListName)); //Adds the file name to the listBox excluding the extension.
            }
        }

        /// <summary>
        /// Import a word list file and read the contents into a string array.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadWordList(object sender, EventArgs e)
        {
            ClearLists(); //Clears all lists and arrays before loading a new word list.
            string file = listBoxWordList.SelectedItem.ToString().ToLower(); //Assigns selected word list item text to the string to be passed as a variable to the file path below.
            string path;
            if (Program.resourcesFoldersFound)
            {
                path = Program.portableVersion ? Program.wordListsFolderLocationPortable + file + ".txt" : Program.wordListsFolderLocation + file + ".txt"; //Assigns the path to the file.
            }
            else
            {
                path = Properties.Settings.Default.customResourcesPath + @"WordLists\" + file + ".txt";
            }
            string[] lines = File.ReadAllLines(path); //Reads each line from the text file into a string array.

            GetEnglishWords(lines);
            GetPhoneticWords(lines);
            GetSyllabaryWordS(lines);
            PopulateListboxes();
            MakeListBoxesVisible();
            WriteToList();
        }

        /// <summary>
        /// Copy each English word from the file to an array.
        /// </summary>
        /// <param name="_lines"></param>
        private void GetEnglishWords(string[] _lines)
        {
            int k = 0; //A counter to interate through each seperate translation string array.
            //For loop to copy the English word for each line into listBox1.
            foreach(string line in _lines)
            {
                string[] columns = line.Split(',');
                for (int j = 0; j< columns.Length; j += 3)
                {
                    if (columns[j] == "")
                    {
                        englishWords[k++] = "Not provided";
                    }
                    else
                    {
                        englishWords[k++] = columns[j];
                    }
                }
            }
        }

        /// <summary>
        /// Copy each Phonetic word from the file to an array.
        /// </summary>
        /// <param name="_lines"></param>
        private void GetPhoneticWords(string[] _lines)
        {
            int k = 0; //A counter to interate through each seperate translation string array.
            //For loop to copy the Phonetic word for each line into listBox2.
            foreach (string line in _lines)
            {
                string[] columns = line.Split(',');
                for (int j = 1; j < columns.Length; j += 3)
                {
                    if (columns[j] == "")
                    {
                        phoneticWords[k++] = "Not provided";
                    }
                    else
                    {
                        phoneticWords[k++] = columns[j];
                    }
                }
            }
        }

        /// <summary>
        /// Copy each Syllabary word from the file to an array.
        /// </summary>
        /// <param name="_lines"></param>
        private void GetSyllabaryWordS(string[] _lines)
        {
            int k = 0; //A counter to interate through each seperate translation string array.
            //For loop to copy the Syllabary word for each line into listBox3.
            foreach (string line in _lines)
            {
                string[] columns = line.Split(',');
                for (int j = 2; j < columns.Length; j += 3)
                {
                    if (columns[j] == "")
                    {
                        syllabaryWords[k++] = "Not provided";
                    }
                    else
                    {
                        syllabaryWords[k++] = columns[j];
                    }
                }
            }
        }

        /// <summary>
        /// Clear each listbox and array before a new word list is loaded.
        /// </summary>
        private void ClearLists()
        {
            //Clear each Listbox.
            listBoxEnglish.Items.Clear();
            listBoxPhonetic.Items.Clear();
            listBoxSyllabary.Items.Clear();
            //Reset size of each Listbox after clear.
            ResetListBoxHeight();
            //Clear each string array.
            Array.Clear(englishWords, 0, 30);
            Array.Clear(phoneticWords, 0, 30);
            Array.Clear(syllabaryWords, 0, 30);
        }

        /// <summary>
        /// Reset the listbox height after it has been cleared.
        /// </summary>
        private void ResetListBoxHeight()
        {
            listBoxEnglish.Height = 0;
            listBoxPhonetic.Height = 0;
            listBoxSyllabary.Height = 0;
        }

        /// <summary>
        /// Add words to each listbox depending on if the word is English, Phonetic, or Syllabary.
        /// </summary>
        private void PopulateListboxes()
        {
            foreach (string _english in englishWords)
            {
                if (_english != null)
                {
                    if (listBoxEnglish.Height < 28) // Check if the listbox height is less then required for the first item. It is set to zero each time a new list is selected.
                    {
                        listBoxEnglish.Items.Add(_english);
                        listBoxEnglish.Height = 28; // Set the listbox height to 28 for the first item added.
                    }
                    else
                    {
                        listBoxEnglish.Items.Add(_english);
                        listBoxEnglish.Height += 24; // Increase the listbox height by 24 for each added item.
                    }
                }
            }

            foreach (string _phonetic in phoneticWords)
            {
                if (_phonetic != null)
                {
                    if (listBoxPhonetic.Height < 28)
                    {
                        listBoxPhonetic.Items.Add(_phonetic);
                        listBoxPhonetic.Height = 28;
                    }
                    else
                    {
                        listBoxPhonetic.Items.Add(_phonetic);
                        listBoxPhonetic.Height += 24;
                    }
                }
            }

            foreach (string _syllabary in syllabaryWords)
            {
                if (_syllabary != null)
                {
                    if (listBoxSyllabary.Height < 28)
                    {
                        listBoxSyllabary.Items.Add(_syllabary);
                        listBoxSyllabary.Height = 28;
                    }
                    else
                    {
                        listBoxSyllabary.Items.Add(_syllabary);
                        listBoxSyllabary.Height += 24;
                    }
                }
            }
        }

        /// <summary>
        /// Make the listboxes visible after they have been populated.
        /// </summary>
        private void MakeListBoxesVisible()
        {
            listBoxEnglish.Visible = true;
            listBoxPhonetic.Visible = true;
            listBoxSyllabary.Visible = true;
        }

        /// <summary>
        /// Create a list combining all of the seperate translation arrays.
        /// </summary>
        private void WriteToList()
        {
            CherokeeWordList.Clear();
            for (int i = 0; i < listBoxEnglish.Items.Count; i++)
            {
                if (englishWords[i] == null)
                {
                    lblAudioStatus.Text = "Error before English word on line " + (i + 1);
                    lblAudioStatus.Visible = true;
                }
                else if (phoneticWords[i] == null)
                {
                    lblAudioStatus.Text = "Error before Phonetic word on line " + (i + 1);
                    lblAudioStatus.Visible = true;
                }
                else if (syllabaryWords[i] == null)
                {
                    lblAudioStatus.Text = "Error before Syllabary word on line " + (i + 1);
                    lblAudioStatus.Visible = true;
                }    
                else
                {
                    CherokeeWordList.Add(new Cherokee() { English = englishWords[i].ToString(), Phonetic = phoneticWords[i].ToString(), Syllabary = syllabaryWords[i].ToString() });
                    lblAudioStatus.Visible = false;
                }
            }
        }

        /// <summary>
        /// Allows playing audio clips from language.cherokee.org/word-list.
        /// </summary>
        /// <param name="sentListBox"></param>
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

        /// <summary>
        /// Close the Phonetic Practice form and return to the Main Menu form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GoToMainMenu(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
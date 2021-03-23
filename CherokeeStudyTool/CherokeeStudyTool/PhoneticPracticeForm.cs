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
        }

        private void ImportNewList(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                ofd.Filter = "txt files (*.txt)|*.txt";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string filePath = ofd.FileName;
                    listBoxWordList.Items.Add(System.IO.Path.GetFileNameWithoutExtension(filePath));
                }
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
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/WordLists/" + file + ".txt"; //Looks for the file in My Documents/WordLists/.
            string[] lines = System.IO.File.ReadAllLines(path); //Reads each line from the text file into a string array.

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
                    englishWords[k++] = columns[j];
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
                    phoneticWords[k++] = columns[j];
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
                    syllabaryWords[k++] = columns[j];
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
                    listBoxEnglish.Items.Add(_english);
                    listBoxEnglish.Height += 24; //Increase the listbox height based on the number of added items.
                }
            }

            foreach (string _phonetic in phoneticWords)
            {
                if (_phonetic != null)
                {
                    listBoxPhonetic.Items.Add(_phonetic);
                    listBoxPhonetic.Height += 24;
                }
            }

            foreach (string _syllabary in syllabaryWords)
            {
                if (_syllabary != null)
                {
                    listBoxSyllabary.Items.Add(_syllabary);
                    listBoxSyllabary.Height += 24;
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

        private void WriteToList()
        {
            CherokeeWordList.Clear();
            for (int i = 0; i < listBoxEnglish.Items.Count; i++)
            {
                CherokeeWordList.Add(new Cherokee() { English = englishWords[i].ToString(), Phonetic = phoneticWords[i].ToString(), Syllabary = syllabaryWords[i].ToString() });
            }
        }

        /// <summary>
        /// Allows playing audio clips from language.cherokee.org/word-list.
        /// </summary>
        /// <param name="sentListBox"></param>
        private void PlayCherokeeAudio(object sender, EventArgs e)
        {
            //bool isAudioAvailable = true;
            ListBox lb = sender as ListBox;
            if (lb.SelectedItem == null)
            {
                return;
            }

            WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
            string wordString = CherokeeWordList[lb.SelectedIndex].English;
            player.URL = @"https://data.cherokee.org/Cherokee/LexiconSoundFiles/" + wordString + ".mp3";

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(player.URL);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    player.controls.play();
                    label2.Visible = false;
                }
                if(WMPPlayState.wmppsTransitioning == player.playState)
                {
                    label2.Text = "Playing";
                    label2.Visible = true;
                }

                response.Close();
            }
            catch (WebException ex)
            {
                if (ex.Status == WebExceptionStatus.ProtocolError && ex.Response != null)
                {
                    var resp = (HttpWebResponse)ex.Response;
                    if (resp.StatusCode == HttpStatusCode.NotFound)
                    {
                        label2.Text = "Audio Unavailable";
                        label2.Visible = true;
                    }
                }
                else
                { throw; }
            }
        }

        /// <summary>
        /// Close this form and return to the Phonetic Menu form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GoToPhoneticMenu(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

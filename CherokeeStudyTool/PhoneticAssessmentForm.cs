﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CherokeeLanguageLearningTool
{
    public partial class PhoneticAssessmentForm : Form
    {
        UserRecords phoneticRecord = new UserRecords(MainMenuForm.firstname, MainMenuForm.lastname);
        List<Cherokee> CherokeeWordList = new List<Cherokee>();
        List<Cherokee> RandomOrderWords = new List<Cherokee>();
        private string[] englishWords = new string[150];
        private string[] phoneticWords = new string[150];
        private static Random rng = new Random();
        private int score = 0;
        private int minutesRemaining;
        private int secondsRemaining;
        private int counter = 10;

        public PhoneticAssessmentForm()
        {
            InitializeComponent();
            ReadWordList();
            phoneticRecord.LoadUserRecord(phoneticRecord);
        }

        /// <summary>
        /// Sets values to default, enables form controls, and starts the LoadWords method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BeginRound(object sender, EventArgs e)
        {
            minutesRemaining = 5; //Round timer minute placeholder.
            secondsRemaining = 30; //Round timer seconds placeholder. Eventually multiple time options will be available.
            score = 0; //Resets the score when a round starts

            timerPhoneticAssessment.Enabled = true;
            btnBegin.Enabled = false;
            btnEnd.Enabled = true;

            if (checkBox3.Checked)
            {
                lblTopScore.Text = "High Score: " + phoneticRecord.TopEnglishScore;
            }
            else
            {
                lblTopScore.Text = "High Score: " + phoneticRecord.TopPhoneticScore;
            }

            TextBox[] allTextBoxes = { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9, textBox10 };
            foreach (TextBox tb in allTextBoxes) //Clears and enables each textbox.
            {
                tb.Clear();
                tb.Enabled = true;
                tb.Visible = true;
            }
            Label[] allLabels = { label1, label2, label3, label4, label5, label6, label7, label8, label9, label10 };
            foreach(Label lb in allLabels) //Makes each label visible.
            {
                lb.Visible = true;
            }
            checkBox3.Enabled = false;
            LoadWords();
        }

        /// <summary>
        /// Open word list file and initialize WriteToList method.
        /// </summary>
        private void ReadWordList()
        {
            string path;
            if (Program.resourcesFoldersFound)
            {
                path = Program.portableVersion ? Program.resourcesFolderLocationPortable + "AllWords.txt" : Program.resourcesFolderLocation + "AllWords.txt";
            }
            else
            {
                path = Properties.Settings.Default.customResourcesPath + "AllWords.txt";
            }
            string[] lines = System.IO.File.ReadAllLines(path);
            GetEnglishWords(lines);
            GetPhoneticWords(lines);
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
                for (int j = 0; j < columns.Length; j += 3)
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
        /// Creates a word list containing the English and Phonetic version for comparison.
        /// </summary>
        private void WriteToList()
        {
            CherokeeWordList.Clear();
            for (int i = 0; i < englishWords.Length; i++)
            {
                if (englishWords[i] != null)
                {
                    CherokeeWordList.Add(new Cherokee() { English = englishWords[i].ToString(), Phonetic = phoneticWords[i].ToString()});
                    RandomOrderWords.Add(new Cherokee() { English = englishWords[i].ToString(), Phonetic = phoneticWords[i].ToString()});
                }
            }
            CreateRandomList(RandomOrderWords);
        }
        
        /// <summary>
        /// Creates a randomized version of the word list.
        /// </summary>
        /// <param name="list"></param>
        private void CreateRandomList(IList<Cherokee> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Cherokee temp = list[k];
                list[k] = list[n];
                list[n] = temp;
            }
            //PrintLists();
        }

        /// <summary>
        /// Loads either Phonetic or English words, based on the selected option, to the labels at the beginning of the round.
        /// </summary>
        private void LoadWords()
        {
            label1.Text = checkBox3.Checked ? RandomOrderWords[0].English.ToString() : RandomOrderWords[0].Phonetic.ToString();
            label2.Text = checkBox3.Checked ? RandomOrderWords[1].English.ToString() : RandomOrderWords[1].Phonetic.ToString();
            label3.Text = checkBox3.Checked ? RandomOrderWords[2].English.ToString() : RandomOrderWords[2].Phonetic.ToString();
            label4.Text = checkBox3.Checked ? RandomOrderWords[3].English.ToString() : RandomOrderWords[3].Phonetic.ToString();
            label5.Text = checkBox3.Checked ? RandomOrderWords[4].English.ToString() : RandomOrderWords[4].Phonetic.ToString();
            label6.Text = checkBox3.Checked ? RandomOrderWords[5].English.ToString() : RandomOrderWords[5].Phonetic.ToString();
            label7.Text = checkBox3.Checked ? RandomOrderWords[6].English.ToString() : RandomOrderWords[6].Phonetic.ToString();
            label8.Text = checkBox3.Checked ? RandomOrderWords[7].English.ToString() : RandomOrderWords[7].Phonetic.ToString();
            label9.Text = checkBox3.Checked ? RandomOrderWords[8].English.ToString() : RandomOrderWords[8].Phonetic.ToString();
            label10.Text = checkBox3.Checked ? RandomOrderWords[9].English.ToString() : RandomOrderWords[9].Phonetic.ToString();
        }

        private void PrintLists()
        {
            for (int n = 0; n < 113; n++)
            {
                Console.WriteLine("Original: " + CherokeeWordList[n].ToString());
                Console.WriteLine("Randomized: " + RandomOrderWords[n].ToString());
            }
        }

        /// <summary>
        /// Compares user entered word to verify match with correct word.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckWord(object sender, EventArgs e)
        {
            TextBox current = sender as TextBox;
            int matchIndex = 0;
            Label lblMyLabel = Controls.Find(current.Tag.ToString(), true).FirstOrDefault() as Label;
            
            if (checkBox3.Checked) //Runs if English to Phonetic is selected
            {
                //Finds the index of the correct word.
                for (int i = 0; i < CherokeeWordList.Count; i++)
                {
                    if (lblMyLabel.Text == CherokeeWordList[i].English)
                    {
                        matchIndex = i;
                    }
                }
                //Allows entry of Phonetic words with or without spaces, and with or without hypens.
                if (current.Text.ToLower().Replace(" ","") == CherokeeWordList[matchIndex].Phonetic.ToLower().Replace("-", string.Empty) || current.Text.ToLower() == CherokeeWordList[matchIndex].Phonetic.ToLower())
                {
                    score++;
                    phoneticRecord.PreviousEnglishScore = score;
                    lblScore.Text = "Current Score: " + score;
                    if(score > phoneticRecord.TopEnglishScore)
                    {
                        phoneticRecord.TopEnglishScore = score;
                    }
                    lblTopScore.Text = "High Score: " + phoneticRecord.TopEnglishScore;
                    current.Clear();
                    LoadNewWord(lblMyLabel);
                }
            }
            else //Runs if checking Phonetic to English
            {
                for (int i = 0; i < CherokeeWordList.Count; i++)
                {
                    if (lblMyLabel.Text == CherokeeWordList[i].Phonetic)
                    {
                        matchIndex = i;
                    }
                }
                if (current.Text.ToLower() == CherokeeWordList[matchIndex].English.ToLower())
                {
                    score++;
                    phoneticRecord.PreviousPhoneticScore = score;
                    lblScore.Text = "Current Score: " + score;
                    if(score > phoneticRecord.TopPhoneticScore)
                    {
                        phoneticRecord.TopPhoneticScore = score;
                    }
                    lblTopScore.Text = "High Score: " + phoneticRecord.TopPhoneticScore;
                    current.Clear();
                    LoadNewWord(lblMyLabel);
                }
            }
        }

        /// <summary>
        /// Loads a new word for a specific label after a correct word is matched.
        /// </summary>
        /// <param name="sentLabel"></param>
        private void LoadNewWord(Label sentLabel)
        {
            sentLabel.Text = checkBox3.Checked ? RandomOrderWords[counter++].English.ToString() : RandomOrderWords[counter++].Phonetic.ToString();
            if (counter >= RandomOrderWords.Count())
            {
                RoundOver();
            }
        }

        /// <summary>
        /// Provides timer updates and ends the round when time is up.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AssessmentTimer(object sender, EventArgs e)
        {
            if(minutesRemaining == 0 && secondsRemaining <= 0) //Checks if timer has reached zero then decrements the time.
            {
                RoundOver();
            }
            lblTimer.Text = "Time Remaining: " + minutesRemaining + ":" + secondsRemaining.ToString("D2");  //Updates the displayed time.
            secondsRemaining--;
            if(minutesRemaining > 0)
            {
                if (secondsRemaining < 0)
                {
                    minutesRemaining--;
                    secondsRemaining = 59;
                }
            }
        }

        /// <summary>
        /// Disables the form when time has ended for the current round.
        /// </summary>
        private void RoundOver()
        {
            timerPhoneticAssessment.Stop();
            lblTimer.Text = "Time Is Up";
            TextBox[] allTextBoxes = { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9, textBox10 };
            foreach(TextBox tb in allTextBoxes)
            {
                tb.Clear();
                tb.Enabled = false;
            }
            checkBox3.Enabled = true;
            btnBegin.Enabled = true;
            btnEnd.Enabled = false;
            minutesRemaining = 0;
            secondsRemaining = 0;
            score = 0;
            timerPhoneticAssessment.Enabled = false;
            RecordPerformance();
        }

        private void RecordPerformance()
        {
            if (checkBox3.Checked)
            {
                phoneticRecord.AttemptedEnglishAssessments++;
            }
            else
            {
                phoneticRecord.AttemptedPhoneticAssessments++;
            }
            if(phoneticRecord.TopEnglishScore < phoneticRecord.PreviousEnglishScore && checkBox3.Checked)
            {
                phoneticRecord.TopEnglishScore = phoneticRecord.PreviousEnglishScore;
            }
            if(phoneticRecord.TopPhoneticScore < phoneticRecord.PreviousPhoneticScore && !checkBox3.Checked)
            {
                phoneticRecord.TopPhoneticScore = phoneticRecord.PreviousPhoneticScore;
            }

            phoneticRecord.SaveUserRecord(phoneticRecord);
        }

        private void ToggleTranslation(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                lblDirections.Text = "Enter Phonetic Translation";
            }
            if (!checkBox3.Checked)
            {
                lblDirections.Text = "Enter English Translation";
            }
        }

        private void EndRound(object sender, EventArgs e)
        {
            
            RoundOver();
        }

        private void ShowInstructions(object sender, EventArgs e)
        {
            HelpForm instructions = new HelpForm();
            instructions.ShowDialog();
        }

        /// <summary>
        /// Close the Phonetic Assessment form and return to the Main Menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GoToMainMenu(object sender, EventArgs e)
        {
            if(btnEnd.Enabled)
            {
                RoundOver();
            }
            this.Close();
        }
    }
}
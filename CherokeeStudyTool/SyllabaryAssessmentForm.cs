using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CherokeeStudyTool
{
    
    public partial class SyllabaryAssessmentForm : Form
    {
        UserRecords syllabaryRecord = new UserRecords(MainMenuForm.firstname, MainMenuForm.lastname);
        private int minutesRemaining;
        private int secondsRemaining;
        private int score = 0;
        private string[] phoneticSyllables = new string[86];

        public SyllabaryAssessmentForm()
        {
            InitializeComponent();
            syllabaryRecord.LoadUserRecord(syllabaryRecord);
        }

        /// <summary>
        /// Enables the timer, textboxes, and pictureboxes, then calls the LoadPhoneticSyllables method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BeginRound(object sender, EventArgs e)
        {
            minutesRemaining = 5;
            secondsRemaining = 30;
            score = 0;

            timerSyllabaryAssessment.Enabled = true;
            btnBegin.Enabled = false;
            btnEnd.Enabled = true;
            
            lblHighScore.Text = "High Score: " + syllabaryRecord.TopSyllabaryScore;


            if (!timerSyllabaryAssessment.Enabled) { lblTimer.Text = "Untimed"; }

            TextBox[] allTextBoxes = { textBox1, textBox2, textBox3, textBox4 };
            foreach(TextBox tb in allTextBoxes)
            {
                tb.Clear();
                tb.Enabled = true;
                tb.Visible = true;
            }

            PictureBox[] allPictureBoxes = { pictureBox1, pictureBox2, pictureBox3, pictureBox4 };
            foreach(PictureBox pb in allPictureBoxes)
            {
                pb.Visible = true;
            }
            LoadPhoneticSyllables();
        }

        /// <summary>
        /// Reads Cherokee Phonetic text file into an array then call the LoadImages method.
        /// </summary>
        private void LoadPhoneticSyllables()
        {
            string path;
            if (Program.resourcesFoldersFound)
            {
                path = Program.portableVersion ? Program.resourcesFolderLocationPortable + "Cherokee Phonetic.txt" : Program.resourcesFolderLocation + "Cherokee Phonetic.txt";
            }
            else
            {
                path = Properties.Settings.Default.customResourcesPath + "Cherokee Phonetic.txt";
            }
            string[] lines = System.IO.File.ReadAllLines(path);
            int k = 0;
            foreach(string line in lines)
            {
                string[] columns = line.Split(',');
                for (int j = 0; j < columns.Length; j++)
                {
                    phoneticSyllables[k++] = columns[j];
                }
            }
            LoadImages();
        }

        /// <summary>
        /// Selects random images to load into the pictureboxes when the round begins.
        /// </summary>
        private void LoadImages()
        {
            Random rnd = new Random();
            int pb1 = rnd.Next(0, phoneticSyllables.Length);
            int pb2 = rnd.Next(0, phoneticSyllables.Length);
            int pb3 = rnd.Next(0, phoneticSyllables.Length);
            int pb4 = rnd.Next(0, phoneticSyllables.Length);

            pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject(phoneticSyllables[pb1].ToString());
            pictureBox1.Tag = phoneticSyllables[pb1].ToString();

            pictureBox2.Image = (Image)Properties.Resources.ResourceManager.GetObject(phoneticSyllables[pb2].ToString());
            pictureBox2.Tag = phoneticSyllables[pb2].ToString();

            pictureBox3.Image = (Image)Properties.Resources.ResourceManager.GetObject(phoneticSyllables[pb3].ToString());
            pictureBox3.Tag = phoneticSyllables[pb3].ToString();

            pictureBox4.Image = (Image)Properties.Resources.ResourceManager.GetObject(phoneticSyllables[pb4].ToString());
            pictureBox4.Tag = phoneticSyllables[pb4].ToString();
        }

        /// <summary>
        /// Compare the Phonetic syllable entered by the user against the image displayed in the picturebox. If matched increase score and load a new image.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckMatch(object sender, EventArgs e)
        {
            TextBox current = sender as TextBox;
            PictureBox currentPictureBox = Controls.Find(current.Tag.ToString(), true).FirstOrDefault() as PictureBox;
            if(currentPictureBox == null)
            {
                Console.WriteLine("PictureBox not assigned!");
            }

            if (current.Text == currentPictureBox.Tag.ToString())
            {
                score++;
                syllabaryRecord.PreviousSyllabaryScore = score;
                lblScore.Text = "Current Score: " + score;
                if(score > syllabaryRecord.TopSyllabaryScore)
                {
                    syllabaryRecord.TopSyllabaryScore = score;
                }
                lblHighScore.Text = "High Score: " + syllabaryRecord.TopSyllabaryScore;
                current.Clear();
                LoadNewImage(currentPictureBox);
            }
        }

        /// <summary>
        /// Find a new image to replace the correctly guessed one.
        /// </summary>
        /// <param name="sentPictureBox"></param>
        private void LoadNewImage(PictureBox sentPictureBox)
        {
            Random rnd = new Random();
            int pbRandom = rnd.Next(0, phoneticSyllables.Length);
            PictureBox[] pictureBoxes = { pictureBox1, pictureBox2, pictureBox3, pictureBox4 };
            string newImage = phoneticSyllables[pbRandom].ToString();
            bool imageExists = false;

            foreach (PictureBox pictureBox in pictureBoxes)
            {
                if(newImage == pictureBox.Tag.ToString())
                {
                    imageExists = true;
                }
                else
                {
                    imageExists = false;
                }
            }
            if (imageExists)
            {
                LoadNewImage(sentPictureBox);
            }
            else
            {
                sentPictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject(phoneticSyllables[pbRandom].ToString());
                sentPictureBox.Tag = phoneticSyllables[pbRandom].ToString();
            }
        }

        /// <summary>
        /// Monitors the timer to determine if the round is over. Updates the timer label.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AssessmentTimer(object sender, EventArgs e)
        {
            if(minutesRemaining == 0 && secondsRemaining <= 0)
            {
                RoundOver();
            }
            lblTimer.Text = "Time Remaining: " + minutesRemaining + ":" + secondsRemaining.ToString("D2");
            secondsRemaining--;
            if (minutesRemaining > 0)
            {
                if (secondsRemaining < 0)
                {
                    minutesRemaining--;
                    secondsRemaining = 59;
                }
            }
        }

        /// <summary>
        /// Disables the form input when time is up for the round. Calls the RecordPerformance method.
        /// </summary>
        private void RoundOver()
        {
            timerSyllabaryAssessment.Stop();
            lblTimer.Text = "Time Is Up";
            TextBox[] allTextBoxes = { textBox1, textBox2, textBox3, textBox4 };
            foreach(TextBox tb in allTextBoxes)
            {
                tb.Clear();
                tb.Enabled = false;
            }
            btnBegin.Enabled = true;
            btnEnd.Enabled = false;
            minutesRemaining = 0;
            secondsRemaining = 0;
            score = 0;
            timerSyllabaryAssessment.Enabled = false;
            RecordPerformance();
        }

        /// <summary>
        /// Records the round performance.
        /// </summary>
        private void RecordPerformance()
        {
            //syllabaryRecord.previousSyllabaryScore = score;
            syllabaryRecord.AttemptedSyllabaryAssessments++;

            if (syllabaryRecord.TopSyllabaryScore < syllabaryRecord.PreviousSyllabaryScore)
            {
                syllabaryRecord.TopSyllabaryScore = syllabaryRecord.PreviousSyllabaryScore;
            }
            syllabaryRecord.SaveUserRecord(syllabaryRecord);
        }
        private void EndRound(object sender, EventArgs e)
        {
            RoundOver();
        }

        /// <summary>
        /// Load the Instructions form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowInstructions(object sender, EventArgs e)
        {
            HelpForm instructions = new HelpForm();
            instructions.ShowDialog();
        }

        /// <summary>
        /// Close the Syllabary Assessment form and return to the Main Menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GoToMainMenu(object sender, EventArgs e)
        {
            if (btnEnd.Enabled)
            {
                RoundOver();
            }
            this.Close();
        }
    }
}
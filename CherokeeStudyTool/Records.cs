using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CherokeeStudyTool
{
    public partial class Records : Form
    {
        
        public Records()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads user record data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void LoadRecord(object sender, EventArgs e)
        {
            UserRecords record = new UserRecords(textBoxFirstName.Text, textBoxLastName.Text); //Creates an object with the first and last name entered.
            record.LoadUserRecord(record); //Retrives the record associated with the username and passes the created object to retrieve the record data.
            if (!record.Exists) //Checks if user record exists.
            {
                Label[] labels = { lblName, lblPreviousPhoneticScore, lblTopPhoneticScore, lblPhoneticAssessmentsAttempted, lblPreviousSyllabaryScore, lblTopSyllabaryScore, lblSyllabaryAssessmentsAttempted, lblPreviousEnglishScore, lblTopEnglishScore, lblEnglishAssessmentsAttempted, lblLearnerLevel};
                foreach (Label label in labels)
                {
                    label.Visible = false; //Hides all labels since no information is available to display.
                }
                lblName.Text = "Record does not exist"; //Changes label to show that the record does not exist.
                lblName.Visible = true; //Makes the label visible.
            }
            else //If the user record exists all data displayed.
            {
                Label[] labels = { lblName, lblPreviousPhoneticScore, lblTopPhoneticScore, lblPhoneticAssessmentsAttempted, lblPreviousSyllabaryScore, lblTopSyllabaryScore, lblSyllabaryAssessmentsAttempted, lblPreviousEnglishScore, lblTopEnglishScore, lblEnglishAssessmentsAttempted, lblLearnerLevel };
                foreach (Label label in labels)
                {
                    label.Visible = true; //Makes the labels visible so the retrieved records can be displayed.
                }
                lblName.Text = record.Firstname + " " + record.Lastname;
                lblPreviousPhoneticScore.Text = "Previous Score: " + record.PreviousPhoneticScore;
                lblTopPhoneticScore.Text = "Top Score: " + record.TopPhoneticScore;
                lblPhoneticAssessmentsAttempted.Text = "Assessments Attempted: " + record.AttemptedPhoneticAssessments;
                lblPreviousSyllabaryScore.Text = "Previous Score: " + record.PreviousSyllabaryScore;
                lblTopSyllabaryScore.Text = "Top Score: " + record.TopSyllabaryScore;
                lblSyllabaryAssessmentsAttempted.Text = "Assessments Attempted: " + record.AttemptedSyllabaryAssessments;
                lblPreviousEnglishScore.Text = "Previous Score: " + record.PreviousEnglishScore;
                lblTopEnglishScore.Text = "Top Score: " + record.TopEnglishScore;
                lblEnglishAssessmentsAttempted.Text = "Assessments Attempted: " + record.AttemptedEnglishAssessments;
                lblLearnerLevel.Text = "Level: " + record.LearnerLevel;
            }
        }

        /// <summary>
        /// Verifies key presses inside the textbox to allow alphanumeric and backspace entries.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VerifyCharacter(object sender, KeyPressEventArgs e)
        {
            Regex keyVerify = new Regex(@"[^a-zA-Z0-9\s\b\-]"); // Regular expression to allow entry of lowercase letters, uppercase letters, numbers, and spaces. Also allows the backspace key for error correction.
            if (keyVerify.IsMatch(e.KeyChar.ToString()))        // Verifies the keypress matches the allowed characters.
            {
                e.Handled = true;
            }
        }
        
        /// <summary>
        /// Closes the Records form and returns to the Main Menu form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReturnToMainMenu(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
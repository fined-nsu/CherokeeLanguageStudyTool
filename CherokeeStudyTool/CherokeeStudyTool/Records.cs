using System;
using System.Windows.Forms;

namespace CherokeeStudyTool
{
    public partial class Records : Form
    {
        
        public Records()
        {
            InitializeComponent();
        }

        public void LoadRecord(object sender, EventArgs e)
        {
            UserRecords record = new UserRecords(textBoxFirstName.Text, textBoxLastName.Text);
            record.LoadUserRecord(record);
            if (!record.Exists)
            {
                Label[] labels = { lblName, lblPreviousPhoneticScore, lblTopPhoneticScore, lblPhoneticAssessmentsAttempted, lblPreviousSyllabaryScore, lblTopSyllabaryScore, lblSyllabaryAssessmentsAttempted, lblPreviousEnglishScore, lblTopEnglishScore, lblEnglishAssessmentsAttempted, lblLearnerLevel};
                foreach (Label label in labels)
                {
                    label.Visible = false;
                }
                lblName.Text = "Record does not exist";
                lblName.Visible = true;
            }
            else
            {
                Label[] labels = { lblName, lblPreviousPhoneticScore, lblTopPhoneticScore, lblPhoneticAssessmentsAttempted, lblPreviousSyllabaryScore, lblTopSyllabaryScore, lblSyllabaryAssessmentsAttempted, lblPreviousEnglishScore, lblTopEnglishScore, lblEnglishAssessmentsAttempted, lblLearnerLevel };
                foreach (Label label in labels)
                {
                    label.Visible = true;
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

        private void ReturnToMainMenu(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
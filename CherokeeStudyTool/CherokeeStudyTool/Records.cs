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
            UserRecords record = new UserRecords(textBoxName.Text);
            record.LoadUserRecord();
            if (!record.exists)
            {
                Label[] labels = { lblName, lblPreviousPhoneticScore, lblTopPhoneticScore, lblPhoneticAssessmentsCompleted, lblPreviousSyllabaryScore, lblTopSyllabaryScore, lblSyllabaryAssessmentsCompleted, lblPreviousEnglishScore, lblTopEnglishScore, lblEnglishAssessmentsCompleted, lblLearnerLevel};
                foreach (Label label in labels)
                {
                    label.Visible = false;
                }
                lblName.Text = "Record does not exist";
                lblName.Visible = true;
            }
            else
            {
                Label[] labels = { lblName, lblPreviousPhoneticScore, lblTopPhoneticScore, lblPhoneticAssessmentsCompleted, lblPreviousSyllabaryScore, lblTopSyllabaryScore, lblSyllabaryAssessmentsCompleted, lblPreviousEnglishScore, lblTopEnglishScore, lblEnglishAssessmentsCompleted, lblLearnerLevel };
                foreach (Label label in labels)
                {
                    label.Visible = true;
                }
                lblName.Text = record.username;
                lblPreviousPhoneticScore.Text = "Previous Score: " + record.previousPhoneticScore;
                lblTopPhoneticScore.Text = "Top Score: " + record.topPhoneticScore;
                lblPhoneticAssessmentsCompleted.Text = "Assessments Completed: " + record.completedPhoneticAssessments;
                lblPreviousSyllabaryScore.Text = "Previous Score: " + record.previousSyllabaryScore;
                lblTopSyllabaryScore.Text = "Top Score: " + record.topSyllabaryScore;
                lblSyllabaryAssessmentsCompleted.Text = "Assessments Completed: " + record.completedSyllabaryAssessments;
                lblPreviousEnglishScore.Text = "Previous Score: " + record.previousEnglishScore;
                lblTopEnglishScore.Text = "Top Score: " + record.topEnglishScore;
                lblEnglishAssessmentsCompleted.Text = "Assessments Completed: " + record.completedEnglishAssessments;
                lblLearnerLevel.Text = "Level: " + record.learnerLevel;
            }
        }

        private void ReturnToMainMenu(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
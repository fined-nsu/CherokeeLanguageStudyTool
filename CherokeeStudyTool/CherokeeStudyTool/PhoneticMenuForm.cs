using System;
using WMPLib;
using System.Windows.Forms;

namespace CherokeeStudyTool
{
    public partial class PhoneticMenuForm : Form
    {
        public PhoneticMenuForm()
        {
            InitializeComponent();
        }

        private void btnPhoneticStudy_Click(object sender, EventArgs e)
        {
            PhoneticPracticeForm PhoneticStudy = new PhoneticPracticeForm();
            PhoneticStudy.ShowDialog();
        }

        private void btnPhoneticAssessment_Click(object sender, EventArgs e)
        {
            PhoneticAssessmentForm PhoneticAssessment = new PhoneticAssessmentForm();
            PhoneticAssessment.ShowDialog();
        }

        private void GoToMainMenu(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

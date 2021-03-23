using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CherokeeStudyTool
{
    public partial class SyllabaryMenuForm : Form
    {
        public SyllabaryMenuForm()
        {
            InitializeComponent();
        }

        private void LoadSyllabaryPractice(object sender, EventArgs e)
        {
            SyllabaryPracticeForm SyllabaryPractice = new SyllabaryPracticeForm();
            SyllabaryPractice.ShowDialog();
        }

        private void LoadSyllabaryAssessment(object sender, EventArgs e)
        {
            SyllabaryAssessmentForm SyllabaryAssessment = new SyllabaryAssessmentForm();
            SyllabaryAssessment.ShowDialog();
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

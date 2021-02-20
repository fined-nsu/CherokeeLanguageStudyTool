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
    
    public partial class SyllabaryAssessmentForm : Form
    {
        private int timeRemaining = 60;
        public SyllabaryAssessmentForm()
        {
            InitializeComponent();
            cycleImagesTest();
        }

        private void GoToSyllabaryMenu(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cycleImagesTest()
        {
            
                pictureBox1.Image = (Image)Cherokee.images.Last();
        }

        private void ReloadImages(object sender, EventArgs e)
        {

        }

        private void Assessment(object sender, EventArgs e)
        {
            lblTimer.Text = "Time Remaining: " + --timeRemaining;

            if(timeRemaining == 0)
            {
                RoundOver();
            }
        }
        private void RoundOver()
        {
            timerAssessment.Stop();

        }
    }
}

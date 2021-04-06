using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CherokeeStudyTool
{
    public partial class SyllabaryPracticeForm : Form
    {
        public SyllabaryPracticeForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Compare text entered in a textbox and display the corrosponding Syllabary character when a match is found.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            TextBox currentTextBox = sender as TextBox;
            PictureBox currentPictureBox = Controls.Find(currentTextBox.Tag.ToString(), true).FirstOrDefault() as PictureBox;
            string resourcename = currentTextBox.Text.ToLower(); // Uses to lower to accept upper and lower case characters from the textbox.
            currentPictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject(resourcename); // Passes the string from the textbox to match a resource name.
            currentPictureBox.Visible = true;
            NullImageCheck(currentPictureBox);
        }

        /// <summary>
        /// Hide the picturebox if the assigned image is invalid.
        /// </summary>
        /// <param name="pb"></param>
        private void NullImageCheck(PictureBox pb)
        {
            if (pb.Image == null)
            {
                pb.Visible = false;
            }
        }

        /// <summary>
        /// Close the Syllabary Practice form and return to the Main Menu form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GoToMainMenu(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
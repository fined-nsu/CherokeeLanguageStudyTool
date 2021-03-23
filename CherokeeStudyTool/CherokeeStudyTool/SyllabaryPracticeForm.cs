using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CherokeeStudyTool
{
    public partial class SyllabaryPracticeForm : Form
    {
        static string concatenatedPhonetic = "";
        //string[] images = System.IO.Directory.GetFiles(@"..\..\Resources", "*.png");


        public SyllabaryPracticeForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Exit the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
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
        /// Prototype method to concatenate the user entered textbox content.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateFromTextBoxes(object sender, EventArgs e)
        {
            concatenatedPhonetic = "";
            TextBox[] textboxes = { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8 };
            PictureBox[] pictureboxes = { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8 };
            int i = 0;
            foreach(TextBox tb in textboxes)
            {
                if(tb.Text != "" && pictureboxes[i].Visible)
                {
                    if(i>0)
                    {
                        concatenatedPhonetic += "-";
                    }
                    concatenatedPhonetic += tb.Text;
                    i++;
                }
            }
            label2.Text = concatenatedPhonetic;
        }

        /// <summary>
        /// Close the current form and return to the Syllabary Menu form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GoToMainMenu(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
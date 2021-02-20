using System;
using System.Drawing;
using System.Windows.Forms;

namespace CherokeeStudyTool
{
    public partial class SyllabaryPracticeForm : Form
    {
        //string[] images = System.IO.Directory.GetFiles(@"..\..\Resources", "*.png");
        public SyllabaryPracticeForm()
        {
            InitializeComponent();
        }

        private void Exit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string resourcename = textBox1.Text.ToLower(); // Uses to lower to accept upper and lower case characters from the textbox.
            pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject(resourcename); // Passes the string from the textbox to match a resource name.
            pictureBox1.Visible = true;
            NullImageCheck(pictureBox1);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string resourcename = textBox2.Text.ToLower(); // Uses to lower to accept upper and lower case characters from the textbox.
            pictureBox2.Image = (Image)Properties.Resources.ResourceManager.GetObject(resourcename); // Passes the string from the textbox to match a resource name.
            pictureBox2.Visible = true;
            NullImageCheck(pictureBox2);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string resourcename = textBox3.Text.ToLower(); // Uses to lower to accept upper and lower case characters from the textbox.
            pictureBox3.Image = (Image)Properties.Resources.ResourceManager.GetObject(resourcename); // Passes the string from the textbox to match a resource name.
            pictureBox3.Visible = true;
            NullImageCheck(pictureBox3);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string resourcename = textBox4.Text.ToLower(); // Uses to lower to accept upper and lower case characters from the textbox.
            pictureBox4.Image = (Image)Properties.Resources.ResourceManager.GetObject(resourcename); // Passes the string from the textbox to match a resource name.
            pictureBox4.Visible = true;
            NullImageCheck(pictureBox4);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string resourcename = textBox5.Text.ToLower(); // Uses to lower to accept upper and lower case characters from the textbox.
            pictureBox5.Image = (Image)Properties.Resources.ResourceManager.GetObject(resourcename); // Passes the string from the textbox to match a resource name.
            pictureBox5.Visible = true;
            NullImageCheck(pictureBox5);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            string resourcename = textBox6.Text.ToLower(); // Uses to lower to accept upper and lower case characters from the textbox.
            pictureBox6.Image = (Image)Properties.Resources.ResourceManager.GetObject(resourcename); // Passes the string from the textbox to match a resource name.
            pictureBox6.Visible = true;
            NullImageCheck(pictureBox6);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            string resourcename = textBox7.Text.ToLower(); // Uses to lower to accept upper and lower case characters from the textbox.
            pictureBox7.Image = (Image)Properties.Resources.ResourceManager.GetObject(resourcename); // Passes the string from the textbox to match a resource name.
            pictureBox7.Visible = true;
            NullImageCheck(pictureBox7);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            string resourcename = textBox8.Text.ToLower(); // Uses to lower to accept upper and lower case characters from the textbox.
            pictureBox8.Image = (Image)Properties.Resources.ResourceManager.GetObject(resourcename); // Passes the string from the textbox to match a resource name.
            pictureBox8.Visible = true;
            NullImageCheck(pictureBox8);
        }

        private void NullImageCheck(PictureBox pb)
        {
            if (pb.Image == null)
            {
                pb.Visible = false;
            }
        }
    }
}
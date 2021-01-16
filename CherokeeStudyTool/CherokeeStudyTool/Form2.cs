using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CherokeeStudyTool
{
    public partial class Form2 : Form
    {
        string[] images = System.IO.Directory.GetFiles(@"C:\Users\fined\Google Drive\School\Capstone\Resources\Images\Syllabary", "*.png");
        int i = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Exit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            pictureBox1.Image = new Bitmap(images[i++]);
            if (i > images.Length - 1)
            {
                i = 0;
            }
        }
    }
}

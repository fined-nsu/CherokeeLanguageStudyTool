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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loadSyllabaryForm(object sender, EventArgs e)
        {
            Form2 Syllabary = new Form2();
            Syllabary.ShowDialog();
        }

        private void Exit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadList()
        {
           
        }
    }
}

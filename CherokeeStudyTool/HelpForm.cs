using System;
using System.Windows.Forms;

namespace CherokeeLanguageLearningTool
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void GoToMainMenu(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

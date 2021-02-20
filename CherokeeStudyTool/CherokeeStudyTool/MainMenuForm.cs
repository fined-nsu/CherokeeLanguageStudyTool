using System;
using System.Windows.Forms;

namespace CherokeeStudyTool
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void loadSyllabaryForm(object sender, EventArgs e)
        {
            SyllabaryMenuForm SyllabaryMenu = new SyllabaryMenuForm();
            SyllabaryMenu.ShowDialog();
        }

        private void Exit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadList()
        {
           
        }

        private void LoadPhoneticMenuForm(object sender, EventArgs e)
        {
            PhoneticMenuForm PhoneticMenu = new PhoneticMenuForm();
            PhoneticMenu.ShowDialog();
        }

        private void LoadHelpForm(object sender, EventArgs e)
        {
            HelpForm instructions = new HelpForm();
            instructions.ShowDialog();
        }
    }
}

using System;
using System.Windows.Forms;
using System.IO;

namespace CherokeeStudyTool
{
    public partial class MainMenuForm : Form
    {
        public static string username = "";
        UserRecords newUser = new UserRecords(username);

        public MainMenuForm()
        {
            InitializeComponent();
        }
        private void LoadPhoneticMenuForm(object sender, EventArgs e)
        {
            username = textBoxUsername.Text;
            /*string path = @"C:\Users\fined\Google Drive\School\Capstone\Records\" + username + "Record.txt";
            // If user record doesn't exist a new record is created.
            if (!File.Exists(path))
            {
                newUser.SaveUserRecord();
            }*/

            PhoneticMenuForm PhoneticMenu = new PhoneticMenuForm();
            PhoneticMenu.ShowDialog();
        }

        private void loadSyllabaryForm(object sender, EventArgs e)
        {
            username = textBoxUsername.Text;

           /* string path = @"C:\Users\fined\Google Drive\School\Capstone\Records\" + username + "Record.txt";
            // If user record doesn't exist a new record is created.,
            if (!File.Exists(path))
            {
                newUser.SaveUserRecord();
            }*/

            SyllabaryMenuForm SyllabaryMenu = new SyllabaryMenuForm();
            SyllabaryMenu.ShowDialog();
        }


        private void loadList()
        {
           
        }


        private void LoadHelpForm(object sender, EventArgs e)
        {
            HelpForm instructions = new HelpForm();
            instructions.ShowDialog();
        }
        private void Exit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadRecordsForm(object sender, EventArgs e)
        {
            Records userRecords = new Records();
            userRecords.ShowDialog();
        }
    }
}

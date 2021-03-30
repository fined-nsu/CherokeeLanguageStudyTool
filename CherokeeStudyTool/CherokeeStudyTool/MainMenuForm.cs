using System;
using System.Windows.Forms;

namespace CherokeeStudyTool
{
    public partial class MainMenuForm : Form
    {
        public static string firstname = "";
        public static string lastname = "";
        UserRecords newUser = new UserRecords(firstname,lastname);

        public MainMenuForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads the Phonetic Practice form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadPhoneticPractice(object sender, EventArgs e)
        {
            PhoneticPracticeForm PhoneticStudy = new PhoneticPracticeForm();
            PhoneticStudy.ShowDialog();
        }

        /// <summary>
        /// Loads the Phonetic Assessment form and stores the user name entered on the Main Menu form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadPhoneticAssessment(object sender, EventArgs e)
        {
            firstname = textBoxFirstname.Text;
            lastname = textBoxLastname.Text;

            PhoneticAssessmentForm PhoneticAssessment = new PhoneticAssessmentForm();
            PhoneticAssessment.ShowDialog();
        }

        /// <summary>
        /// Loads the Syllabary Practice form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadSyllabaryPractice(object sender, EventArgs e)
        {
            SyllabaryPracticeForm SyllabaryStudy = new SyllabaryPracticeForm();
            SyllabaryStudy.ShowDialog();
        }

        /// <summary>
        /// Loads the Syllabary Assessment form and stores the user name entered on the Main Menu form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadSyllabaryAssessment(object sender, EventArgs e)
        {
            firstname = textBoxFirstname.Text;
            lastname = textBoxLastname.Text;

            SyllabaryAssessmentForm SyllabaryAssessment = new SyllabaryAssessmentForm();
            SyllabaryAssessment.ShowDialog();
        }

        /// <summary>
        /// Loads the Instructions form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadHelpForm(object sender, EventArgs e)
        {
            HelpForm instructions = new HelpForm();
            instructions.ShowDialog();
        }

        /// <summary>
        /// Loads the Records form and stores the user name entered on the Main Menu form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadRecordsForm(object sender, EventArgs e)
        {
            firstname = textBoxFirstname.Text;
            lastname = textBoxLastname.Text;

            Records userRecords = new Records();
            userRecords.ShowDialog();
        }

        /// <summary>
        /// Exits the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

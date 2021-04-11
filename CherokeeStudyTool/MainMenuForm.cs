using System;
using System.Text.RegularExpressions; // See https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regex?view=net-5.0 for more information on using regular expressions.
using System.Windows.Forms;

namespace CherokeeLanguageLearningTool
{
    public partial class MainMenuForm : Form
    {
        public static string firstname = "";
        public static string lastname = "";
        UserRecords newUser = new UserRecords(firstname, lastname);

        public MainMenuForm()
        {
            InitializeComponent();
            Program.CheckResources();
            Console.WriteLine(Properties.Settings.Default.customResourcesPath);
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
        /// Verifies key presses inside the textbox to allow alphanumeric and backspace entries.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxVerify_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex keyVerify = new Regex(@"[^a-zA-Z0-9\s\b\-]"); // Regular expression to allow entry of lowercase letters, uppercase letters, numbers, and spaces. Also allows the backspace key for error correction.
            if (keyVerify.IsMatch(e.KeyChar.ToString()))        // Verifies the keypress matches the allowed characters.
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Load the Settings form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadSettingsForm(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
        }

        /// <summary>
        /// Load the About form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadAboutForm(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
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
using System;
using System.Windows.Forms;

namespace CherokeeLanguageLearningTool
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void ReturnToMainMenu(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Link to the Cherokee Nation's Cherokee language program website.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GoToCherokeeLanguageSite(object sender, LinkLabelLinkClickedEventArgs e) //Link label info: https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.linklabel?view=net-5.0
        {
            this.linkLabelCherokeeLanguageSite.LinkVisited = true;
            System.Diagnostics.Process.Start("https://language.cherokee.org/");
        }

        /// <summary>
        /// Link to the project GitHub repository.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GoToGitHubRepository(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabelGitHubRepository.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/fined-nsu/CherokeeLanguageStudyTool");
        }
    }
}

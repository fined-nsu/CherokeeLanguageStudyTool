using System;
using System.IO;
using System.Windows.Forms;

namespace CherokeeStudyTool
{
    public partial class Settings : Form
    {
        string currentPath;
        public Settings()
        {
            InitializeComponent();
            LoadInfo();
            LoadWordListsFromResources();
        }

        /// <summary>
        /// Load current path information in the textBoxes.
        /// </summary>
        private void LoadInfo()
        {
            if (Properties.Settings.Default.customResourcesPath == "")
            {
                textBoxResourcesLocation.Text = "Not Set";
            }
            else
            {
                textBoxResourcesLocation.Text = Properties.Settings.Default.customResourcesPath;
            }
            if (Properties.Settings.Default.customWordListsPath == "")
            {
                textBoxWordListsLocation.Text = "Not Set";
            }
            else
            {
                textBoxWordListsLocation.Text = Properties.Settings.Default.customWordListsPath;
            }
            if (Properties.Settings.Default.customRecordsPath == "")
            {
                textBoxRecordsLocation.Text = "Not Set";
            }
            else
            {
                textBoxRecordsLocation.Text = Properties.Settings.Default.customRecordsPath;
            }
        }

        /// <summary>
        /// Reset custom folder paths to empty strings. Reload and run the CheckResources method to reset.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetPaths(Object sender, EventArgs e)
        {
            Properties.Settings.Default.customResourcesPath = "";
            Properties.Settings.Default.customWordListsPath = "";
            Properties.Settings.Default.customRecordsPath = "";
            Properties.Settings.Default.Save();
            LoadInfo();
            Program.CheckResources();
        }

        /// <summary>
        /// Populates the listBox with available word lists from the applications Resources\WordLists folder.
        /// </summary>
        private void LoadWordListsFromResources()
        {
            string[] wordLists;
            if (Program.resourcesFoldersFound)
            {
                wordLists = Program.portableVersion ? Directory.GetFiles(Program.wordListsFolderLocationPortable, "*.txt") : Directory.GetFiles(Program.wordListsFolderLocation, "*.txt"); //Allows changing paths by just switching the boolean value for portableVersion.
                currentPath = Program.portableVersion ? Program.wordListsFolderLocationPortable : Program.wordListsFolderLocation;
            }
            else
            {
                wordLists = Directory.GetFiles(Properties.Settings.Default.customWordListsPath, "*.txt"); //Uses directory selected by user if the default locations are not present.
                currentPath = Properties.Settings.Default.customWordListsPath;
            }


            foreach (string wordlist in wordLists) //Iterates through each word list filename stored in the wordLists array.
            {
                string wordListName;
                if (Program.resourcesFoldersFound)
                {
                    wordListName = Program.portableVersion ? wordlist.Substring(Program.wordListsFolderLocationPortable.Length) : wordlist.Substring(Program.wordListsFolderLocation.Length);  //Creates a substring without the file path.
                }
                else
                {
                    wordListName = wordlist.Substring(Properties.Settings.Default.customWordListsPath.Length);
                }
                listBoxWordList.Items.Add(Path.GetFileNameWithoutExtension(wordListName)); //Adds the file name to the listBox excluding the extension.
            }
        }

        /// <summary>
        /// A method to allow the import of new word lists for use in the applications. Imported lists are copied to the Resources folder in the applications ProgramData folder.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportNewList(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                ofd.Filter = "txt files (*.txt)|*.txt";


                if (ofd.ShowDialog() == DialogResult.OK)    //Checks if the file dialog returns OK. Skips if it returns Cancel.
                {
                    string filePath = ofd.FileName; //Stores the path of the user's file to import.
                    string fileName = Path.GetFileName(filePath);  //Gets the filename.
                    string copyPath;
                    if (Program.wordListsFoldersFound)
                    {
                        copyPath = Program.portableVersion ? Program.wordListsFolderLocationPortable + fileName : Program.wordListsFolderLocation + fileName;    //Stores the path for the applications Resource folder in ProgramData.
                    }
                    else
                    {
                        copyPath = Properties.Settings.Default.customWordListsPath + fileName;
                    }

                    listBoxWordList.Items.Add(Path.GetFileNameWithoutExtension(filePath));  //The imported word list file name is added to the listbox so it can be used without reloading the form.
                    File.Copy(filePath, copyPath, true);    //The imported word list is copied so the user doesn't have to import each time.
                }
            }
        }

        /// <summary>
        /// Delete the selected word list file and remove it from the list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveSelectedList(object sender, EventArgs e)
        {
            string fileName = listBoxWordList.SelectedItem.ToString();
            Console.WriteLine(currentPath + fileName);
            File.Delete(currentPath + fileName + ".txt");
            listBoxWordList.Items.Remove(listBoxWordList.SelectedItem);
        }

        /// <summary>
        /// Set the custom path to the Resources folder.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LocateResourcesFolder(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.Description = "Select the Resources folder";
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.customResourcesPath = fbd.SelectedPath + @"\";
                    Console.WriteLine(Properties.Settings.Default.customResourcesPath);
                }
            }
            textBoxResourcesLocation.Text = Properties.Settings.Default.customResourcesPath;
        }

        /// <summary>
        /// Set the custom path to the WordLists folder.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LocateWordListsFolder(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.Description = "Select the WordLists folder";
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.customWordListsPath = fbd.SelectedPath + @"\";
                    Console.WriteLine(Properties.Settings.Default.customWordListsPath);
                }
            }
            textBoxWordListsLocation.Text = Properties.Settings.Default.customWordListsPath;
        }
        /// <summary>
        /// Set the custom path to the Records folder.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LocateRecordsFolder(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.Description = "Records folder not found. Please select the appropriate Records folder.";
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.customRecordsPath = fbd.SelectedPath + @"\";
                    Console.WriteLine(Properties.Settings.Default.customRecordsPath);
                }
            }
            textBoxRecordsLocation.Text = Properties.Settings.Default.customRecordsPath;
        }
        
        /// <summary>
        /// Close the Settings form and return to the Main Menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReturnToMainMenu(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
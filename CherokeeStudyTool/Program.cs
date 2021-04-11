using System;
using System.Windows.Forms;
using System.IO;

namespace CherokeeLanguageLearningTool
{
    static class Program
    {
        public static bool portableVersion = false; //Set this to true before building a standalone version. Set to false for the installable version.

        //Installable version default locations
        public static readonly string resourcesFolderLocation = @"C:\ProgramData\Fine Software\Resources\";
        public static readonly string wordListsFolderLocation = @"C:\ProgramData\Fine Software\Resources\WordLists\";
        public static readonly string recordsFolderLocation = @"C:\ProgramData\Fine Software\Records\";

        //Portable version default locations
        public static string resourcesFolderLocationPortable = @".\Resources\";
        public static string wordListsFolderLocationPortable = @".\Resources\WordLists\";
        public static string recordsFolderLocationPortable = @".\Records\";

        //Boolean values to track if necessary directories are found
        static bool resourcesExists = false;
        static bool resourcesExistsPortable = false;
        static bool wordListsExists = false;
        static bool wordListsExistsPortable = false;
        static bool recordsExists = false;
        static bool recordsExistsPortable = false;
        
        public static bool resourcesFoldersFound = false;
        public static bool wordListsFoldersFound = false;
        public static bool recordsFoldersFound = false;
        static bool customResourcesFolderFound = false;
        static bool customWordListsFolderFound = false;
        static bool customRecordsFolderFound = false;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenuForm());
        }

        /// <summary>
        /// Check if paths to necessary folders exist. If not prompt for manual selection.
        /// </summary>
        public static void CheckResources()
        {
            if (portableVersion)
            {
                if (Directory.Exists(resourcesFolderLocationPortable))
                {
                    resourcesExistsPortable = true;
                }
                if (Directory.Exists(wordListsFolderLocationPortable))
                {
                    wordListsExistsPortable = true;
                }
                if (Directory.Exists(recordsFolderLocationPortable))
                {
                    recordsExistsPortable = true;
                }
            }
            else if (!portableVersion)
            {
                if (Directory.Exists(resourcesFolderLocation))
                {
                    resourcesExists = true;
                }
                if (Directory.Exists(wordListsFolderLocation))
                {
                    wordListsExists = true;
                }
                if (Directory.Exists(recordsFolderLocation))
                {
                    recordsExists = true;
                }
            }

            resourcesFoldersFound = resourcesExists || resourcesExistsPortable;
            wordListsFoldersFound = wordListsExists || wordListsExistsPortable;
            recordsFoldersFound = recordsExists || recordsExistsPortable;

            CheckCustomPaths();

            if (!resourcesFoldersFound && !customResourcesFolderFound) //If the default paths are not found and a custom path is not found or set prompt user to find the location.
            {
                using (FolderBrowserDialog fbd = new FolderBrowserDialog())
                {
                    fbd.Description = "Resources folder not found. Please select the appropriate Resouces folder.";
                    if (fbd.ShowDialog() == DialogResult.OK)
                    {
                        Properties.Settings.Default.customResourcesPath = fbd.SelectedPath + @"\";
                        Console.WriteLine(Properties.Settings.Default.customResourcesPath);
                    }
                }
            }

            if(!wordListsFoldersFound && !customWordListsFolderFound) //If the default paths are not found and a custom path is not found or set prompt user to find the location.
            {
                using (FolderBrowserDialog fbd = new FolderBrowserDialog())
                {
                    fbd.Description = "Word Lists folder not found. Please select the appropriate Word Lists folder.";
                    if (fbd.ShowDialog() == DialogResult.OK)
                    {
                        Properties.Settings.Default.customWordListsPath = fbd.SelectedPath + @"\";
                        Console.WriteLine(Properties.Settings.Default.customWordListsPath);
                    }
                }
            }
            if (!recordsFoldersFound && !customRecordsFolderFound) //If the default paths are not found and a custom path is not found or set prompt user to find the location.
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
            }
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Checks if the previously set custom folder path still exists
        /// </summary>
        public static void CheckCustomPaths()
        {
            if(Directory.Exists(Properties.Settings.Default.customResourcesPath))
            {
                customResourcesFolderFound = true;
            }

            if (Directory.Exists(Properties.Settings.Default.customWordListsPath))
            {
                customWordListsFolderFound = true;
            }

            if (Directory.Exists(Properties.Settings.Default.customRecordsPath))
            {
                customRecordsFolderFound = true;
            }
        }
    }
}

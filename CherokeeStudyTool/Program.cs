using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CherokeeStudyTool
{
    static class Program
    {
        public static bool portableVersion = false;

        //Installable version locations
        public static string resourcesFolderLocation = @"C:\ProgramData\Fine Software\Resources\";
        public static string wordListsFolderLocation = @"C:\ProgramData\Fine Software\Resources\WordLists\";
        public static string recordsFolderLocation = @"C:\ProgramData\Fine Software\Records\";

        //Portable version locations
        public static string resourcesFolderLocationPortable = @".\Resources\";
        public static string wordListsFolderLocationPortable = @".\Resources\WordLists\";
        public static string recordsFolderLocationPortable = @".\Records\";

        //public static string customResourcesPath;
        //public static string customWordListsPath;
        //public static string customRecordsPath;

        static bool resourcesExists = false;
        static bool resourcesExistsPortable = false;
        static bool wordListsExists = false;
        static bool wordListsExistsPortable = false;
        static bool recordsExists = false;
        static bool recordsExistsPortable = false;
        
        public static bool resourcesFoldersFound;
        public static bool wordListFoldersFound;
        public static bool recordsFoldersFound;
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

            resourcesFoldersFound = resourcesExists && resourcesExistsPortable;
            wordListFoldersFound = wordListsExists && wordListsExistsPortable;
            recordsFoldersFound = recordsExists && recordsExistsPortable;

            CheckCustomPaths();

            if (!resourcesFoldersFound && !customResourcesFolderFound)
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

            if(!wordListFoldersFound && !customWordListsFolderFound)
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
            if (!recordsFoldersFound && !customRecordsFolderFound)
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

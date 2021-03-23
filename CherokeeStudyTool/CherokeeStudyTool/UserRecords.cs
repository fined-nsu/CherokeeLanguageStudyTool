using System;
using System.IO;

namespace CherokeeStudyTool
{
    class UserRecords
    {
        public int previousPhoneticScore {get; set;} //Stores the score for the previous Phonetic to English assessment.

        public int topPhoneticScore {get; set;} //Stores the top score for the Phonetic to English assessment.

        public int completedPhoneticAssessments { get; set; } //Counter for number of complete Phonetic to English Assessments.

        public int previousEnglishScore { get; set; } //Stores the score for the previous English to Phonetic assessment.

        public int topEnglishScore { get; set; } //Stores the top score for the English to Phonetic assessment.

        public int completedEnglishAssessments { get; set; } //Counter for number of complete English to Phonetic Assessments.

        public int previousSyllabaryScore{ get; set; } //Stores the score for the previous Syllabary assessment.

        public int topSyllabaryScore { get; set; } //Stores the top score for the Syllabary assessment.

        public int completedSyllabaryAssessments { get; set; } //Counter for number of complete Syllabary Assessments.

        public int learnerLevel {get; set;} //Stores the learner level value.

        public string username {get; set;} //Stores the username string.

        public bool exists { get; set; }

        public UserRecords(string _name) // Constructor that accepts a username and initializes all other values to default.
        {
            username = _name;
            learnerLevel = 1;
            previousPhoneticScore = 0;
            topPhoneticScore = 0;
            completedPhoneticAssessments = 0;
            previousEnglishScore = 0;
            topEnglishScore = 0;
            completedEnglishAssessments = 0;
            previousSyllabaryScore = 0;
            topSyllabaryScore = 0;
            completedSyllabaryAssessments = 0;
        }

        /// <summary>
        /// Save user record
        /// </summary>
        public void SaveUserRecord()
        {
            //Create a method to store the record to a file.
            if (username != "")
            {
                string path = @"C:\Users\fined\Google Drive\School\Capstone\Records\" + username + "Record.txt";

                File.WriteAllText(path, username + "," + previousPhoneticScore + "," + topPhoneticScore + "," + completedPhoneticAssessments + "," + previousEnglishScore + "," + topEnglishScore + "," + completedEnglishAssessments + "," + previousSyllabaryScore + "," + topSyllabaryScore + "," + completedSyllabaryAssessments + "," + learnerLevel);
            }
        }

        /// <summary>
        /// Load user record
        /// </summary>
        public void LoadUserRecord()
        {
            string path = @"C:\Users\fined\Google Drive\School\Capstone\Records\" + username + "Record.txt";
            if (File.Exists(path))
            {
                string userRecordImport = File.ReadAllText(path);
                string[] recordData = userRecordImport.Split(',');
                username = recordData[0];
                previousPhoneticScore = Int32.Parse(recordData[1]);
                topPhoneticScore = Int32.Parse(recordData[2]);
                completedPhoneticAssessments = Int32.Parse(recordData[3]);
                previousEnglishScore = Int32.Parse(recordData[4]);
                topEnglishScore = Int32.Parse(recordData[5]);
                completedEnglishAssessments = Int32.Parse(recordData[6]);
                previousSyllabaryScore = Int32.Parse(recordData[7]);
                topSyllabaryScore = Int32.Parse(recordData[8]);
                completedSyllabaryAssessments = Int32.Parse(recordData[9]);
                learnerLevel = Int32.Parse(recordData[10]);
                exists = true;
            }
            else
            {
                exists = false;
            }
        }
    }
}
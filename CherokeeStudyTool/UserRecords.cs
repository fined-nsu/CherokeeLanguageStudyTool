using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace CherokeeStudyTool
{
    [Serializable]
    class UserRecords
    {
        public int PreviousPhoneticScore {get; set;} //Stores the score for the previous Phonetic to English assessment.

        public int TopPhoneticScore {get; set;} //Stores the top score for the Phonetic to English assessment.

        public int AttemptedPhoneticAssessments { get; set; } //Counter for number of complete Phonetic to English Assessments.

        public int PreviousEnglishScore { get; set; } //Stores the score for the previous English to Phonetic assessment.

        public int TopEnglishScore { get; set; } //Stores the top score for the English to Phonetic assessment.

        public int AttemptedEnglishAssessments { get; set; } //Counter for number of complete English to Phonetic Assessments.

        public int PreviousSyllabaryScore{ get; set; } //Stores the score for the previous Syllabary assessment.

        public int TopSyllabaryScore { get; set; } //Stores the top score for the Syllabary assessment.

        public int AttemptedSyllabaryAssessments { get; set; } //Counter for number of complete Syllabary Assessments.

        public int LearnerLevel {get; set;} //Stores the learner level value.

        public string Firstname {get; set;} //Stores the firstname string.

        public string Lastname { get; set; } //Stores the lastname string.

        public bool Exists { get; set; }

        public UserRecords(string fname, string lname) // Constructor that accepts a username and initializes all other values to default.
        {
            Firstname = fname;
            Lastname = lname;
            LearnerLevel = 1;
            PreviousPhoneticScore = 0;
            TopPhoneticScore = 0;
            AttemptedPhoneticAssessments = 0;
            PreviousEnglishScore = 0;
            TopEnglishScore = 0;
            AttemptedEnglishAssessments = 0;
            PreviousSyllabaryScore = 0;
            TopSyllabaryScore = 0;
            AttemptedSyllabaryAssessments = 0;
        }

        /// <summary>
        /// Saves the user record in a serialized file to reduce ease of data manipulation.
        /// </summary>
        public void SaveUserRecord(UserRecords _record)
        {
            IFormatter formatter = new BinaryFormatter();
            

            //Create a method to store the record to a file.
            string username = Firstname + Lastname;
            if (username != "")
            {
                string path = @"C:\ProgramData\Fine Software\Records\" + username + "Record.txt";
                Stream stream = new FileStream(path, FileMode.Create, FileAccess.Write);
                formatter.Serialize(stream, _record);
                stream.Close();
            }
        }

        /// <summary>
        /// Loads and deserializes the user record.
        /// </summary>
        public void LoadUserRecord(UserRecords _record)
        {
            IFormatter formatter = new BinaryFormatter();
            string path = @"C:\ProgramData\Fine Software\Records\" + Firstname + Lastname + "Record.txt";
            if (File.Exists(path))
            {
                Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
                _record = (UserRecords)formatter.Deserialize(stream);

                Firstname = _record.Firstname;
                Lastname = _record.Lastname;
                PreviousPhoneticScore = _record.PreviousPhoneticScore;
                TopPhoneticScore = _record.TopPhoneticScore;
                AttemptedPhoneticAssessments = _record.AttemptedPhoneticAssessments;
                PreviousEnglishScore = _record.PreviousEnglishScore;
                TopEnglishScore = _record.PreviousEnglishScore;
                AttemptedEnglishAssessments = _record.AttemptedEnglishAssessments;
                PreviousSyllabaryScore = _record.PreviousSyllabaryScore;
                TopSyllabaryScore = _record.TopSyllabaryScore;
                AttemptedSyllabaryAssessments = _record.AttemptedSyllabaryAssessments;
                LearnerLevel = _record.LearnerLevel;
                Exists = true;
                stream.Close();
            }
            else
            {
                Exists = false;
            }
        }
    }
}
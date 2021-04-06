
namespace CherokeeStudyTool
{
    partial class Records
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Records));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.returnToMainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToMainMenuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPreviousPhoneticScore = new System.Windows.Forms.Label();
            this.lblTopPhoneticScore = new System.Windows.Forms.Label();
            this.lblPreviousSyllabaryScore = new System.Windows.Forms.Label();
            this.lblTopSyllabaryScore = new System.Windows.Forms.Label();
            this.btnLoadRecord = new System.Windows.Forms.Button();
            this.lblLearnerLevel = new System.Windows.Forms.Label();
            this.lblPhoneticAssessmentsAttempted = new System.Windows.Forms.Label();
            this.lblSyllabaryAssessmentsAttempted = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblEnglishAssessmentsAttempted = new System.Windows.Forms.Label();
            this.lblTopEnglishScore = new System.Windows.Forms.Label();
            this.lblPreviousEnglishScore = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnToMainMenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1432, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // returnToMainMenuToolStripMenuItem
            // 
            this.returnToMainMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnToMainMenuToolStripMenuItem1});
            this.returnToMainMenuToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.returnToMainMenuToolStripMenuItem.Name = "returnToMainMenuToolStripMenuItem";
            this.returnToMainMenuToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.returnToMainMenuToolStripMenuItem.Text = "File";
            // 
            // returnToMainMenuToolStripMenuItem1
            // 
            this.returnToMainMenuToolStripMenuItem1.BackColor = System.Drawing.Color.SteelBlue;
            this.returnToMainMenuToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.returnToMainMenuToolStripMenuItem1.Name = "returnToMainMenuToolStripMenuItem1";
            this.returnToMainMenuToolStripMenuItem1.Size = new System.Drawing.Size(187, 22);
            this.returnToMainMenuToolStripMenuItem1.Text = "Return to Main Menu";
            this.returnToMainMenuToolStripMenuItem1.Click += new System.EventHandler(this.ReturnToMainMenu);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(17, 30);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(101, 24);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstName.Location = new System.Drawing.Point(21, 56);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(149, 29);
            this.textBoxFirstName.TabIndex = 1;
            this.textBoxFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VerifyCharacter);
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(303, 104);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(68, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            this.lblName.Visible = false;
            // 
            // lblPreviousPhoneticScore
            // 
            this.lblPreviousPhoneticScore.AutoSize = true;
            this.lblPreviousPhoneticScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreviousPhoneticScore.Location = new System.Drawing.Point(18, 41);
            this.lblPreviousPhoneticScore.Name = "lblPreviousPhoneticScore";
            this.lblPreviousPhoneticScore.Size = new System.Drawing.Size(164, 25);
            this.lblPreviousPhoneticScore.TabIndex = 0;
            this.lblPreviousPhoneticScore.Text = "Previous Score:";
            this.lblPreviousPhoneticScore.Visible = false;
            // 
            // lblTopPhoneticScore
            // 
            this.lblTopPhoneticScore.AutoSize = true;
            this.lblTopPhoneticScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopPhoneticScore.Location = new System.Drawing.Point(18, 67);
            this.lblTopPhoneticScore.Name = "lblTopPhoneticScore";
            this.lblTopPhoneticScore.Size = new System.Drawing.Size(117, 25);
            this.lblTopPhoneticScore.TabIndex = 0;
            this.lblTopPhoneticScore.Text = "Top Score:";
            this.lblTopPhoneticScore.Visible = false;
            // 
            // lblPreviousSyllabaryScore
            // 
            this.lblPreviousSyllabaryScore.AutoSize = true;
            this.lblPreviousSyllabaryScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreviousSyllabaryScore.Location = new System.Drawing.Point(18, 41);
            this.lblPreviousSyllabaryScore.Name = "lblPreviousSyllabaryScore";
            this.lblPreviousSyllabaryScore.Size = new System.Drawing.Size(164, 25);
            this.lblPreviousSyllabaryScore.TabIndex = 0;
            this.lblPreviousSyllabaryScore.Text = "Previous Score:";
            this.lblPreviousSyllabaryScore.Visible = false;
            // 
            // lblTopSyllabaryScore
            // 
            this.lblTopSyllabaryScore.AutoSize = true;
            this.lblTopSyllabaryScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopSyllabaryScore.Location = new System.Drawing.Point(18, 67);
            this.lblTopSyllabaryScore.Name = "lblTopSyllabaryScore";
            this.lblTopSyllabaryScore.Size = new System.Drawing.Size(117, 25);
            this.lblTopSyllabaryScore.TabIndex = 0;
            this.lblTopSyllabaryScore.Text = "Top Score:";
            this.lblTopSyllabaryScore.Visible = false;
            // 
            // btnLoadRecord
            // 
            this.btnLoadRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadRecord.Location = new System.Drawing.Point(21, 153);
            this.btnLoadRecord.Name = "btnLoadRecord";
            this.btnLoadRecord.Size = new System.Drawing.Size(149, 42);
            this.btnLoadRecord.TabIndex = 3;
            this.btnLoadRecord.TabStop = false;
            this.btnLoadRecord.Text = "Load Record";
            this.btnLoadRecord.UseVisualStyleBackColor = true;
            this.btnLoadRecord.Click += new System.EventHandler(this.LoadRecord);
            // 
            // lblLearnerLevel
            // 
            this.lblLearnerLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLearnerLevel.AutoSize = true;
            this.lblLearnerLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLearnerLevel.Location = new System.Drawing.Point(803, 104);
            this.lblLearnerLevel.Name = "lblLearnerLevel";
            this.lblLearnerLevel.Size = new System.Drawing.Size(70, 25);
            this.lblLearnerLevel.TabIndex = 0;
            this.lblLearnerLevel.Text = "Level:";
            this.lblLearnerLevel.Visible = false;
            // 
            // lblPhoneticAssessmentsAttempted
            // 
            this.lblPhoneticAssessmentsAttempted.AutoSize = true;
            this.lblPhoneticAssessmentsAttempted.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneticAssessmentsAttempted.Location = new System.Drawing.Point(18, 93);
            this.lblPhoneticAssessmentsAttempted.Name = "lblPhoneticAssessmentsAttempted";
            this.lblPhoneticAssessmentsAttempted.Size = new System.Drawing.Size(249, 25);
            this.lblPhoneticAssessmentsAttempted.TabIndex = 0;
            this.lblPhoneticAssessmentsAttempted.Text = "Assessments Attempted:";
            this.lblPhoneticAssessmentsAttempted.Visible = false;
            // 
            // lblSyllabaryAssessmentsAttempted
            // 
            this.lblSyllabaryAssessmentsAttempted.AutoSize = true;
            this.lblSyllabaryAssessmentsAttempted.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSyllabaryAssessmentsAttempted.Location = new System.Drawing.Point(18, 93);
            this.lblSyllabaryAssessmentsAttempted.Name = "lblSyllabaryAssessmentsAttempted";
            this.lblSyllabaryAssessmentsAttempted.Size = new System.Drawing.Size(249, 25);
            this.lblSyllabaryAssessmentsAttempted.TabIndex = 0;
            this.lblSyllabaryAssessmentsAttempted.Text = "Assessments Attempted:";
            this.lblSyllabaryAssessmentsAttempted.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblPreviousPhoneticScore);
            this.groupBox1.Controls.Add(this.lblTopPhoneticScore);
            this.groupBox1.Controls.Add(this.lblPhoneticAssessmentsAttempted);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(285, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 137);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phonetic to English";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPreviousSyllabaryScore);
            this.groupBox2.Controls.Add(this.lblTopSyllabaryScore);
            this.groupBox2.Controls.Add(this.lblSyllabaryAssessmentsAttempted);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(785, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 137);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Syllabary";
            // 
            // lblEnglishAssessmentsAttempted
            // 
            this.lblEnglishAssessmentsAttempted.AutoSize = true;
            this.lblEnglishAssessmentsAttempted.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnglishAssessmentsAttempted.Location = new System.Drawing.Point(18, 93);
            this.lblEnglishAssessmentsAttempted.Name = "lblEnglishAssessmentsAttempted";
            this.lblEnglishAssessmentsAttempted.Size = new System.Drawing.Size(249, 25);
            this.lblEnglishAssessmentsAttempted.TabIndex = 0;
            this.lblEnglishAssessmentsAttempted.Text = "Assessments Attempted:";
            this.lblEnglishAssessmentsAttempted.Visible = false;
            // 
            // lblTopEnglishScore
            // 
            this.lblTopEnglishScore.AutoSize = true;
            this.lblTopEnglishScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopEnglishScore.Location = new System.Drawing.Point(18, 67);
            this.lblTopEnglishScore.Name = "lblTopEnglishScore";
            this.lblTopEnglishScore.Size = new System.Drawing.Size(117, 25);
            this.lblTopEnglishScore.TabIndex = 0;
            this.lblTopEnglishScore.Text = "Top Score:";
            this.lblTopEnglishScore.Visible = false;
            // 
            // lblPreviousEnglishScore
            // 
            this.lblPreviousEnglishScore.AutoSize = true;
            this.lblPreviousEnglishScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreviousEnglishScore.Location = new System.Drawing.Point(18, 41);
            this.lblPreviousEnglishScore.Name = "lblPreviousEnglishScore";
            this.lblPreviousEnglishScore.Size = new System.Drawing.Size(164, 25);
            this.lblPreviousEnglishScore.TabIndex = 0;
            this.lblPreviousEnglishScore.Text = "Previous Score:";
            this.lblPreviousEnglishScore.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lblPreviousEnglishScore);
            this.groupBox3.Controls.Add(this.lblEnglishAssessmentsAttempted);
            this.groupBox3.Controls.Add(this.lblTopEnglishScore);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(285, 431);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(363, 135);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "English to Phonetic";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxLastName);
            this.groupBox4.Controls.Add(this.lblLastName);
            this.groupBox4.Controls.Add(this.btnLoadRecord);
            this.groupBox4.Controls.Add(this.textBoxFirstName);
            this.groupBox4.Controls.Add(this.lblFirstName);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 75);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(196, 218);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Record Lookup";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastName.Location = new System.Drawing.Point(21, 115);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(149, 29);
            this.textBoxLastName.TabIndex = 2;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(17, 88);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(99, 24);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "Last Name";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(616, 686);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 63);
            this.button1.TabIndex = 4;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ReturnToMainMenu);
            // 
            // Records
            // 
            this.AcceptButton = this.btnLoadRecord;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1432, 761);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblLearnerLevel);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Records";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Records";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem returnToMainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToMainMenuToolStripMenuItem1;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPreviousPhoneticScore;
        private System.Windows.Forms.Label lblTopPhoneticScore;
        private System.Windows.Forms.Label lblPreviousSyllabaryScore;
        private System.Windows.Forms.Label lblTopSyllabaryScore;
        private System.Windows.Forms.Button btnLoadRecord;
        private System.Windows.Forms.Label lblLearnerLevel;
        private System.Windows.Forms.Label lblPhoneticAssessmentsAttempted;
        private System.Windows.Forms.Label lblSyllabaryAssessmentsAttempted;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblEnglishAssessmentsAttempted;
        private System.Windows.Forms.Label lblTopEnglishScore;
        private System.Windows.Forms.Label lblPreviousEnglishScore;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Button button1;
    }
}
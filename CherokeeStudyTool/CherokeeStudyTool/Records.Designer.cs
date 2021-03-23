
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPreviousPhoneticScore = new System.Windows.Forms.Label();
            this.lblTopPhoneticScore = new System.Windows.Forms.Label();
            this.lblPreviousSyllabaryScore = new System.Windows.Forms.Label();
            this.lblTopSyllabaryScore = new System.Windows.Forms.Label();
            this.btnLoadRecord = new System.Windows.Forms.Button();
            this.lblLearnerLevel = new System.Windows.Forms.Label();
            this.lblPhoneticAssessmentsCompleted = new System.Windows.Forms.Label();
            this.lblSyllabaryAssessmentsCompleted = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblEnglishAssessmentsCompleted = new System.Windows.Forms.Label();
            this.lblTopEnglishScore = new System.Windows.Forms.Label();
            this.lblPreviousEnglishScore = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnToMainMenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1031, 24);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(42, 79);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Phoreus Cherokee", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(205, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(72, 26);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            this.lblName.Visible = false;
            // 
            // lblPreviousPhoneticScore
            // 
            this.lblPreviousPhoneticScore.AutoSize = true;
            this.lblPreviousPhoneticScore.Font = new System.Drawing.Font("Phoreus Cherokee", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreviousPhoneticScore.Location = new System.Drawing.Point(219, 113);
            this.lblPreviousPhoneticScore.Name = "lblPreviousPhoneticScore";
            this.lblPreviousPhoneticScore.Size = new System.Drawing.Size(161, 26);
            this.lblPreviousPhoneticScore.TabIndex = 5;
            this.lblPreviousPhoneticScore.Text = "Previous Score:";
            this.lblPreviousPhoneticScore.Visible = false;
            // 
            // lblTopPhoneticScore
            // 
            this.lblTopPhoneticScore.AutoSize = true;
            this.lblTopPhoneticScore.Font = new System.Drawing.Font("Phoreus Cherokee", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopPhoneticScore.Location = new System.Drawing.Point(219, 139);
            this.lblTopPhoneticScore.Name = "lblTopPhoneticScore";
            this.lblTopPhoneticScore.Size = new System.Drawing.Size(112, 26);
            this.lblTopPhoneticScore.TabIndex = 7;
            this.lblTopPhoneticScore.Text = "Top Score:";
            this.lblTopPhoneticScore.Visible = false;
            // 
            // lblPreviousSyllabaryScore
            // 
            this.lblPreviousSyllabaryScore.AutoSize = true;
            this.lblPreviousSyllabaryScore.Font = new System.Drawing.Font("Phoreus Cherokee", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreviousSyllabaryScore.Location = new System.Drawing.Point(589, 113);
            this.lblPreviousSyllabaryScore.Name = "lblPreviousSyllabaryScore";
            this.lblPreviousSyllabaryScore.Size = new System.Drawing.Size(161, 26);
            this.lblPreviousSyllabaryScore.TabIndex = 8;
            this.lblPreviousSyllabaryScore.Text = "Previous Score:";
            this.lblPreviousSyllabaryScore.Visible = false;
            // 
            // lblTopSyllabaryScore
            // 
            this.lblTopSyllabaryScore.AutoSize = true;
            this.lblTopSyllabaryScore.Font = new System.Drawing.Font("Phoreus Cherokee", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopSyllabaryScore.Location = new System.Drawing.Point(589, 139);
            this.lblTopSyllabaryScore.Name = "lblTopSyllabaryScore";
            this.lblTopSyllabaryScore.Size = new System.Drawing.Size(112, 26);
            this.lblTopSyllabaryScore.TabIndex = 9;
            this.lblTopSyllabaryScore.Text = "Top Score:";
            this.lblTopSyllabaryScore.Visible = false;
            // 
            // btnLoadRecord
            // 
            this.btnLoadRecord.Location = new System.Drawing.Point(42, 115);
            this.btnLoadRecord.Name = "btnLoadRecord";
            this.btnLoadRecord.Size = new System.Drawing.Size(75, 23);
            this.btnLoadRecord.TabIndex = 10;
            this.btnLoadRecord.Text = "Load";
            this.btnLoadRecord.UseVisualStyleBackColor = true;
            this.btnLoadRecord.Click += new System.EventHandler(this.LoadRecord);
            // 
            // lblLearnerLevel
            // 
            this.lblLearnerLevel.AutoSize = true;
            this.lblLearnerLevel.Font = new System.Drawing.Font("Phoreus Cherokee", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLearnerLevel.Location = new System.Drawing.Point(574, 42);
            this.lblLearnerLevel.Name = "lblLearnerLevel";
            this.lblLearnerLevel.Size = new System.Drawing.Size(70, 26);
            this.lblLearnerLevel.TabIndex = 11;
            this.lblLearnerLevel.Text = "Level:";
            this.lblLearnerLevel.Visible = false;
            // 
            // lblPhoneticAssessmentsCompleted
            // 
            this.lblPhoneticAssessmentsCompleted.AutoSize = true;
            this.lblPhoneticAssessmentsCompleted.Font = new System.Drawing.Font("Phoreus Cherokee", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneticAssessmentsCompleted.Location = new System.Drawing.Point(219, 165);
            this.lblPhoneticAssessmentsCompleted.Name = "lblPhoneticAssessmentsCompleted";
            this.lblPhoneticAssessmentsCompleted.Size = new System.Drawing.Size(259, 26);
            this.lblPhoneticAssessmentsCompleted.TabIndex = 12;
            this.lblPhoneticAssessmentsCompleted.Text = "Assessments Completed:";
            this.lblPhoneticAssessmentsCompleted.Visible = false;
            // 
            // lblSyllabaryAssessmentsCompleted
            // 
            this.lblSyllabaryAssessmentsCompleted.AutoSize = true;
            this.lblSyllabaryAssessmentsCompleted.Font = new System.Drawing.Font("Phoreus Cherokee", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSyllabaryAssessmentsCompleted.Location = new System.Drawing.Point(589, 165);
            this.lblSyllabaryAssessmentsCompleted.Name = "lblSyllabaryAssessmentsCompleted";
            this.lblSyllabaryAssessmentsCompleted.Size = new System.Drawing.Size(259, 26);
            this.lblSyllabaryAssessmentsCompleted.TabIndex = 13;
            this.lblSyllabaryAssessmentsCompleted.Text = "Assessments Completed:";
            this.lblSyllabaryAssessmentsCompleted.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Phoreus Cherokee", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(210, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 128);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phonetic to English";
            // 
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("Phoreus Cherokee", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(579, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 128);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Syllabary";
            // 
            // lblEnglishAssessmentsCompleted
            // 
            this.lblEnglishAssessmentsCompleted.AutoSize = true;
            this.lblEnglishAssessmentsCompleted.Font = new System.Drawing.Font("Phoreus Cherokee", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnglishAssessmentsCompleted.Location = new System.Drawing.Point(219, 308);
            this.lblEnglishAssessmentsCompleted.Name = "lblEnglishAssessmentsCompleted";
            this.lblEnglishAssessmentsCompleted.Size = new System.Drawing.Size(259, 26);
            this.lblEnglishAssessmentsCompleted.TabIndex = 20;
            this.lblEnglishAssessmentsCompleted.Text = "Assessments Completed:";
            this.lblEnglishAssessmentsCompleted.Visible = false;
            // 
            // lblTopEnglishScore
            // 
            this.lblTopEnglishScore.AutoSize = true;
            this.lblTopEnglishScore.Font = new System.Drawing.Font("Phoreus Cherokee", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopEnglishScore.Location = new System.Drawing.Point(219, 282);
            this.lblTopEnglishScore.Name = "lblTopEnglishScore";
            this.lblTopEnglishScore.Size = new System.Drawing.Size(112, 26);
            this.lblTopEnglishScore.TabIndex = 19;
            this.lblTopEnglishScore.Text = "Top Score:";
            this.lblTopEnglishScore.Visible = false;
            // 
            // lblPreviousEnglishScore
            // 
            this.lblPreviousEnglishScore.AutoSize = true;
            this.lblPreviousEnglishScore.Font = new System.Drawing.Font("Phoreus Cherokee", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreviousEnglishScore.Location = new System.Drawing.Point(219, 256);
            this.lblPreviousEnglishScore.Name = "lblPreviousEnglishScore";
            this.lblPreviousEnglishScore.Size = new System.Drawing.Size(161, 26);
            this.lblPreviousEnglishScore.TabIndex = 18;
            this.lblPreviousEnglishScore.Text = "Previous Score:";
            this.lblPreviousEnglishScore.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Font = new System.Drawing.Font("Phoreus Cherokee", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(210, 230);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(319, 128);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "English to Phonetic";
            // 
            // Records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1031, 461);
            this.Controls.Add(this.lblEnglishAssessmentsCompleted);
            this.Controls.Add(this.lblTopEnglishScore);
            this.Controls.Add(this.lblPreviousEnglishScore);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblSyllabaryAssessmentsCompleted);
            this.Controls.Add(this.lblPhoneticAssessmentsCompleted);
            this.Controls.Add(this.lblLearnerLevel);
            this.Controls.Add(this.btnLoadRecord);
            this.Controls.Add(this.lblTopSyllabaryScore);
            this.Controls.Add(this.lblPreviousSyllabaryScore);
            this.Controls.Add(this.lblTopPhoneticScore);
            this.Controls.Add(this.lblPreviousPhoneticScore);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Records";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Records";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem returnToMainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToMainMenuToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPreviousPhoneticScore;
        private System.Windows.Forms.Label lblTopPhoneticScore;
        private System.Windows.Forms.Label lblPreviousSyllabaryScore;
        private System.Windows.Forms.Label lblTopSyllabaryScore;
        private System.Windows.Forms.Button btnLoadRecord;
        private System.Windows.Forms.Label lblLearnerLevel;
        private System.Windows.Forms.Label lblPhoneticAssessmentsCompleted;
        private System.Windows.Forms.Label lblSyllabaryAssessmentsCompleted;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblEnglishAssessmentsCompleted;
        private System.Windows.Forms.Label lblTopEnglishScore;
        private System.Windows.Forms.Label lblPreviousEnglishScore;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}
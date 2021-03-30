
namespace CherokeeStudyTool
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.recordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFirstname = new System.Windows.Forms.TextBox();
            this.pictureBoxPhonetic = new System.Windows.Forms.PictureBox();
            this.pictureBoxSyllabary = new System.Windows.Forms.PictureBox();
            this.btnPhoneticPractice = new System.Windows.Forms.Button();
            this.btnPhoneticAssessment = new System.Windows.Forms.Button();
            this.btnSyllabaryAssessment = new System.Windows.Forms.Button();
            this.btnSyllabaryPractice = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRecords = new System.Windows.Forms.Button();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.textBoxLastname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhonetic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSyllabary)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(1, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1432, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recordsToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // recordsToolStripMenuItem
            // 
            this.recordsToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.recordsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.recordsToolStripMenuItem.Name = "recordsToolStripMenuItem";
            this.recordsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.recordsToolStripMenuItem.Text = "Records";
            this.recordsToolStripMenuItem.Click += new System.EventHandler(this.LoadRecordsForm);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.BackColor = System.Drawing.Color.SteelBlue;
            this.exitToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.Exit);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionsToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.instructionsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.instructionsToolStripMenuItem.Text = "Instructions";
            this.instructionsToolStripMenuItem.Click += new System.EventHandler(this.LoadHelpForm);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(62, 34);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.Exit);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 40);
            this.label3.TabIndex = 0;
            this.label3.Text = "Enter Name To\r\nTrack Performance";
            // 
            // textBoxFirstname
            // 
            this.textBoxFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstname.Location = new System.Drawing.Point(6, 63);
            this.textBoxFirstname.Name = "textBoxFirstname";
            this.textBoxFirstname.Size = new System.Drawing.Size(188, 29);
            this.textBoxFirstname.TabIndex = 0;
            // 
            // pictureBoxPhonetic
            // 
            this.pictureBoxPhonetic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxPhonetic.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPhonetic.Image")));
            this.pictureBoxPhonetic.Location = new System.Drawing.Point(20, 32);
            this.pictureBoxPhonetic.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBoxPhonetic.Name = "pictureBoxPhonetic";
            this.pictureBoxPhonetic.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxPhonetic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhonetic.TabIndex = 3;
            this.pictureBoxPhonetic.TabStop = false;
            // 
            // pictureBoxSyllabary
            // 
            this.pictureBoxSyllabary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxSyllabary.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSyllabary.Image")));
            this.pictureBoxSyllabary.Location = new System.Drawing.Point(20, 32);
            this.pictureBoxSyllabary.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBoxSyllabary.Name = "pictureBoxSyllabary";
            this.pictureBoxSyllabary.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxSyllabary.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSyllabary.TabIndex = 1;
            this.pictureBoxSyllabary.TabStop = false;
            // 
            // btnPhoneticPractice
            // 
            this.btnPhoneticPractice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhoneticPractice.Location = new System.Drawing.Point(20, 267);
            this.btnPhoneticPractice.Name = "btnPhoneticPractice";
            this.btnPhoneticPractice.Size = new System.Drawing.Size(200, 60);
            this.btnPhoneticPractice.TabIndex = 3;
            this.btnPhoneticPractice.Text = "Practice";
            this.btnPhoneticPractice.UseVisualStyleBackColor = true;
            this.btnPhoneticPractice.Click += new System.EventHandler(this.LoadPhoneticPractice);
            // 
            // btnPhoneticAssessment
            // 
            this.btnPhoneticAssessment.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhoneticAssessment.Location = new System.Drawing.Point(20, 333);
            this.btnPhoneticAssessment.Name = "btnPhoneticAssessment";
            this.btnPhoneticAssessment.Size = new System.Drawing.Size(200, 63);
            this.btnPhoneticAssessment.TabIndex = 4;
            this.btnPhoneticAssessment.Text = "Assessment";
            this.btnPhoneticAssessment.UseVisualStyleBackColor = true;
            this.btnPhoneticAssessment.Click += new System.EventHandler(this.LoadPhoneticAssessment);
            // 
            // btnSyllabaryAssessment
            // 
            this.btnSyllabaryAssessment.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSyllabaryAssessment.Location = new System.Drawing.Point(20, 333);
            this.btnSyllabaryAssessment.Name = "btnSyllabaryAssessment";
            this.btnSyllabaryAssessment.Size = new System.Drawing.Size(200, 63);
            this.btnSyllabaryAssessment.TabIndex = 6;
            this.btnSyllabaryAssessment.Text = "Assessment";
            this.btnSyllabaryAssessment.UseVisualStyleBackColor = true;
            this.btnSyllabaryAssessment.Click += new System.EventHandler(this.LoadSyllabaryAssessment);
            // 
            // btnSyllabaryPractice
            // 
            this.btnSyllabaryPractice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSyllabaryPractice.Location = new System.Drawing.Point(20, 267);
            this.btnSyllabaryPractice.Name = "btnSyllabaryPractice";
            this.btnSyllabaryPractice.Size = new System.Drawing.Size(200, 60);
            this.btnSyllabaryPractice.TabIndex = 5;
            this.btnSyllabaryPractice.Text = "Practice";
            this.btnSyllabaryPractice.UseVisualStyleBackColor = true;
            this.btnSyllabaryPractice.Click += new System.EventHandler(this.LoadSyllabaryPractice);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRecords);
            this.groupBox1.Controls.Add(this.lblLastName);
            this.groupBox1.Controls.Add(this.lblFirstName);
            this.groupBox1.Controls.Add(this.textBoxLastname);
            this.groupBox1.Controls.Add(this.textBoxFirstname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(39, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 284);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Name";
            // 
            // btnRecords
            // 
            this.btnRecords.Location = new System.Drawing.Point(11, 215);
            this.btnRecords.Name = "btnRecords";
            this.btnRecords.Size = new System.Drawing.Size(183, 60);
            this.btnRecords.TabIndex = 2;
            this.btnRecords.Text = "View Records";
            this.btnRecords.UseVisualStyleBackColor = true;
            this.btnRecords.Click += new System.EventHandler(this.LoadRecordsForm);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(7, 100);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(108, 24);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(7, 36);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(111, 24);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // textBoxLastname
            // 
            this.textBoxLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastname.Location = new System.Drawing.Point(6, 127);
            this.textBoxLastname.Name = "textBoxLastname";
            this.textBoxLastname.Size = new System.Drawing.Size(188, 29);
            this.textBoxLastname.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(635, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Select A Mode";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(616, 686);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 63);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.Exit);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBoxPhonetic);
            this.groupBox2.Controls.Add(this.btnPhoneticPractice);
            this.groupBox2.Controls.Add(this.btnPhoneticAssessment);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(362, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 420);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phonetic";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSyllabaryPractice);
            this.groupBox3.Controls.Add(this.btnSyllabaryAssessment);
            this.groupBox3.Controls.Add(this.pictureBoxSyllabary);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(831, 146);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(239, 420);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Syllabary";
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1432, 761);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cherokee Language Study Tool";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhonetic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSyllabary)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxSyllabary;
        private System.Windows.Forms.PictureBox pictureBoxPhonetic;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructionsToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFirstname;
        private System.Windows.Forms.ToolStripMenuItem recordsToolStripMenuItem;
        private System.Windows.Forms.Button btnPhoneticPractice;
        private System.Windows.Forms.Button btnPhoneticAssessment;
        private System.Windows.Forms.Button btnSyllabaryAssessment;
        private System.Windows.Forms.Button btnSyllabaryPractice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox textBoxLastname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRecords;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}


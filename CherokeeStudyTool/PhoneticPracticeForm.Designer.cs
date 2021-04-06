
namespace CherokeeStudyTool
{
    partial class PhoneticPracticeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhoneticPracticeForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToMainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxWordList = new System.Windows.Forms.ListBox();
            this.listBoxEnglish = new System.Windows.Forms.ListBox();
            this.listBoxPhonetic = new System.Windows.Forms.ListBox();
            this.listBoxSyllabary = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAudioStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1432, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importListToolStripMenuItem,
            this.returnToMainMenuToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importListToolStripMenuItem
            // 
            this.importListToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.importListToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.importListToolStripMenuItem.Name = "importListToolStripMenuItem";
            this.importListToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.importListToolStripMenuItem.Text = "Import List";
            this.importListToolStripMenuItem.Click += new System.EventHandler(this.ImportNewList);
            // 
            // returnToMainMenuToolStripMenuItem
            // 
            this.returnToMainMenuToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.returnToMainMenuToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.returnToMainMenuToolStripMenuItem.Name = "returnToMainMenuToolStripMenuItem";
            this.returnToMainMenuToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.returnToMainMenuToolStripMenuItem.Text = "Return to Main Menu";
            this.returnToMainMenuToolStripMenuItem.Click += new System.EventHandler(this.GoToMainMenu);
            // 
            // listBoxWordList
            // 
            this.listBoxWordList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxWordList.FormattingEnabled = true;
            this.listBoxWordList.ItemHeight = 24;
            this.listBoxWordList.Location = new System.Drawing.Point(12, 55);
            this.listBoxWordList.MaximumSize = new System.Drawing.Size(206, 652);
            this.listBoxWordList.Name = "listBoxWordList";
            this.listBoxWordList.Size = new System.Drawing.Size(206, 196);
            this.listBoxWordList.Sorted = true;
            this.listBoxWordList.TabIndex = 1;
            this.listBoxWordList.SelectedIndexChanged += new System.EventHandler(this.LoadWordList);
            // 
            // listBoxEnglish
            // 
            this.listBoxEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxEnglish.FormattingEnabled = true;
            this.listBoxEnglish.ItemHeight = 24;
            this.listBoxEnglish.Location = new System.Drawing.Point(339, 55);
            this.listBoxEnglish.Name = "listBoxEnglish";
            this.listBoxEnglish.Size = new System.Drawing.Size(350, 28);
            this.listBoxEnglish.TabIndex = 3;
            this.listBoxEnglish.Visible = false;
            this.listBoxEnglish.SelectedIndexChanged += new System.EventHandler(this.PlayCherokeeAudio);
            // 
            // listBoxPhonetic
            // 
            this.listBoxPhonetic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPhonetic.FormattingEnabled = true;
            this.listBoxPhonetic.ItemHeight = 24;
            this.listBoxPhonetic.Location = new System.Drawing.Point(695, 55);
            this.listBoxPhonetic.Name = "listBoxPhonetic";
            this.listBoxPhonetic.Size = new System.Drawing.Size(350, 28);
            this.listBoxPhonetic.TabIndex = 3;
            this.listBoxPhonetic.Visible = false;
            this.listBoxPhonetic.SelectedIndexChanged += new System.EventHandler(this.PlayCherokeeAudio);
            // 
            // listBoxSyllabary
            // 
            this.listBoxSyllabary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSyllabary.FormattingEnabled = true;
            this.listBoxSyllabary.ItemHeight = 24;
            this.listBoxSyllabary.Location = new System.Drawing.Point(1051, 55);
            this.listBoxSyllabary.Name = "listBoxSyllabary";
            this.listBoxSyllabary.Size = new System.Drawing.Size(350, 28);
            this.listBoxSyllabary.TabIndex = 3;
            this.listBoxSyllabary.Visible = false;
            this.listBoxSyllabary.SelectedIndexChanged += new System.EventHandler(this.PlayCherokeeAudio);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select A Word List";
            // 
            // lblAudioStatus
            // 
            this.lblAudioStatus.AutoSize = true;
            this.lblAudioStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAudioStatus.Location = new System.Drawing.Point(12, 635);
            this.lblAudioStatus.Name = "lblAudioStatus";
            this.lblAudioStatus.Size = new System.Drawing.Size(134, 25);
            this.lblAudioStatus.TabIndex = 5;
            this.lblAudioStatus.Text = "Audio Status";
            this.lblAudioStatus.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(475, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "English";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(788, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Phonetic";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1146, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Syllabary";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(12, 686);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(200, 63);
            this.btnClose.TabIndex = 9;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.GoToMainMenu);
            // 
            // PhoneticPracticeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1432, 761);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAudioStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxSyllabary);
            this.Controls.Add(this.listBoxPhonetic);
            this.Controls.Add(this.listBoxEnglish);
            this.Controls.Add(this.listBoxWordList);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "PhoneticPracticeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phonetic Practice";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToMainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importListToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxWordList;
        private System.Windows.Forms.ListBox listBoxEnglish;
        private System.Windows.Forms.ListBox listBoxPhonetic;
        private System.Windows.Forms.ListBox listBoxSyllabary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAudioStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClose;
    }
}

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
            this.label2 = new System.Windows.Forms.Label();
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
            this.importListToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.importListToolStripMenuItem.Text = "Import List";
            this.importListToolStripMenuItem.Click += new System.EventHandler(this.ImportNewList);
            // 
            // returnToMainMenuToolStripMenuItem
            // 
            this.returnToMainMenuToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.returnToMainMenuToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.returnToMainMenuToolStripMenuItem.Name = "returnToMainMenuToolStripMenuItem";
            this.returnToMainMenuToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.returnToMainMenuToolStripMenuItem.Text = "Return to Phonetic Menu";
            this.returnToMainMenuToolStripMenuItem.Click += new System.EventHandler(this.GoToPhoneticMenu);
            // 
            // listBoxWordList
            // 
            this.listBoxWordList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxWordList.FormattingEnabled = true;
            this.listBoxWordList.ItemHeight = 24;
            this.listBoxWordList.Items.AddRange(new object[] {
            "Colors",
            "Numbers",
            "Relationships",
            "Food and Drink",
            "Animals",
            "Emotions",
            "Days and Months",
            "Weather",
            "Nature"});
            this.listBoxWordList.Location = new System.Drawing.Point(12, 55);
            this.listBoxWordList.Name = "listBoxWordList";
            this.listBoxWordList.Size = new System.Drawing.Size(206, 220);
            this.listBoxWordList.TabIndex = 1;
            this.listBoxWordList.SelectedIndexChanged += new System.EventHandler(this.LoadWordList);
            // 
            // listBoxEnglish
            // 
            this.listBoxEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxEnglish.FormattingEnabled = true;
            this.listBoxEnglish.ItemHeight = 24;
            this.listBoxEnglish.Location = new System.Drawing.Point(340, 27);
            this.listBoxEnglish.Name = "listBoxEnglish";
            this.listBoxEnglish.Size = new System.Drawing.Size(350, 4);
            this.listBoxEnglish.TabIndex = 3;
            this.listBoxEnglish.Visible = false;
            this.listBoxEnglish.SelectedIndexChanged += new System.EventHandler(this.PlayCherokeeAudio);
            // 
            // listBoxPhonetic
            // 
            this.listBoxPhonetic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPhonetic.FormattingEnabled = true;
            this.listBoxPhonetic.ItemHeight = 24;
            this.listBoxPhonetic.Location = new System.Drawing.Point(696, 27);
            this.listBoxPhonetic.Name = "listBoxPhonetic";
            this.listBoxPhonetic.Size = new System.Drawing.Size(350, 4);
            this.listBoxPhonetic.TabIndex = 3;
            this.listBoxPhonetic.Visible = false;
            this.listBoxPhonetic.SelectedIndexChanged += new System.EventHandler(this.PlayCherokeeAudio);
            // 
            // listBoxSyllabary
            // 
            this.listBoxSyllabary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSyllabary.FormattingEnabled = true;
            this.listBoxSyllabary.ItemHeight = 24;
            this.listBoxSyllabary.Location = new System.Drawing.Point(1052, 27);
            this.listBoxSyllabary.Name = "listBoxSyllabary";
            this.listBoxSyllabary.Size = new System.Drawing.Size(350, 4);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 569);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // PhoneticPracticeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1432, 681);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxSyllabary);
            this.Controls.Add(this.listBoxPhonetic);
            this.Controls.Add(this.listBoxEnglish);
            this.Controls.Add(this.listBoxWordList);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PhoneticPracticeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cherokee Phonetic Study";
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
        private System.Windows.Forms.Label label2;
    }
}
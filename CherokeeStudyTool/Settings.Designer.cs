
namespace CherokeeStudyTool
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.buttonResourcesLocate = new System.Windows.Forms.Button();
            this.buttonWordListsLocate = new System.Windows.Forms.Button();
            this.buttonRecordsLocate = new System.Windows.Forms.Button();
            this.textBoxResourcesLocation = new System.Windows.Forms.TextBox();
            this.textBoxWordListsLocation = new System.Windows.Forms.TextBox();
            this.textBoxRecordsLocation = new System.Windows.Forms.TextBox();
            this.labelResources = new System.Windows.Forms.Label();
            this.labelRecords = new System.Windows.Forms.Label();
            this.labelWordLists = new System.Windows.Forms.Label();
            this.buttonResetDefaults = new System.Windows.Forms.Button();
            this.listBoxWordList = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToMainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonImportList = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonResourcesLocate
            // 
            this.buttonResourcesLocate.Location = new System.Drawing.Point(412, 57);
            this.buttonResourcesLocate.Name = "buttonResourcesLocate";
            this.buttonResourcesLocate.Size = new System.Drawing.Size(104, 31);
            this.buttonResourcesLocate.TabIndex = 0;
            this.buttonResourcesLocate.Text = "Browse";
            this.buttonResourcesLocate.UseVisualStyleBackColor = true;
            this.buttonResourcesLocate.Click += new System.EventHandler(this.LocateResourcesFolder);
            // 
            // buttonWordListsLocate
            // 
            this.buttonWordListsLocate.Location = new System.Drawing.Point(412, 128);
            this.buttonWordListsLocate.Name = "buttonWordListsLocate";
            this.buttonWordListsLocate.Size = new System.Drawing.Size(104, 31);
            this.buttonWordListsLocate.TabIndex = 0;
            this.buttonWordListsLocate.Text = "Browse";
            this.buttonWordListsLocate.UseVisualStyleBackColor = true;
            this.buttonWordListsLocate.Click += new System.EventHandler(this.LocateWordListsFolder);
            // 
            // buttonRecordsLocate
            // 
            this.buttonRecordsLocate.Location = new System.Drawing.Point(412, 199);
            this.buttonRecordsLocate.Name = "buttonRecordsLocate";
            this.buttonRecordsLocate.Size = new System.Drawing.Size(104, 31);
            this.buttonRecordsLocate.TabIndex = 0;
            this.buttonRecordsLocate.Text = "Browse";
            this.buttonRecordsLocate.UseVisualStyleBackColor = true;
            this.buttonRecordsLocate.Click += new System.EventHandler(this.LocateRecordsFolder);
            // 
            // textBoxResourcesLocation
            // 
            this.textBoxResourcesLocation.Location = new System.Drawing.Point(12, 59);
            this.textBoxResourcesLocation.Name = "textBoxResourcesLocation";
            this.textBoxResourcesLocation.Size = new System.Drawing.Size(394, 29);
            this.textBoxResourcesLocation.TabIndex = 1;
            // 
            // textBoxWordListsLocation
            // 
            this.textBoxWordListsLocation.Location = new System.Drawing.Point(12, 130);
            this.textBoxWordListsLocation.Name = "textBoxWordListsLocation";
            this.textBoxWordListsLocation.Size = new System.Drawing.Size(394, 29);
            this.textBoxWordListsLocation.TabIndex = 1;
            // 
            // textBoxRecordsLocation
            // 
            this.textBoxRecordsLocation.Location = new System.Drawing.Point(12, 201);
            this.textBoxRecordsLocation.Name = "textBoxRecordsLocation";
            this.textBoxRecordsLocation.Size = new System.Drawing.Size(394, 29);
            this.textBoxRecordsLocation.TabIndex = 1;
            // 
            // labelResources
            // 
            this.labelResources.AutoSize = true;
            this.labelResources.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResources.Location = new System.Drawing.Point(12, 36);
            this.labelResources.Name = "labelResources";
            this.labelResources.Size = new System.Drawing.Size(86, 20);
            this.labelResources.TabIndex = 2;
            this.labelResources.Text = "Resources";
            // 
            // labelRecords
            // 
            this.labelRecords.AutoSize = true;
            this.labelRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecords.Location = new System.Drawing.Point(12, 178);
            this.labelRecords.Name = "labelRecords";
            this.labelRecords.Size = new System.Drawing.Size(69, 20);
            this.labelRecords.TabIndex = 2;
            this.labelRecords.Text = "Records";
            // 
            // labelWordLists
            // 
            this.labelWordLists.AutoSize = true;
            this.labelWordLists.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWordLists.Location = new System.Drawing.Point(12, 107);
            this.labelWordLists.Name = "labelWordLists";
            this.labelWordLists.Size = new System.Drawing.Size(84, 20);
            this.labelWordLists.TabIndex = 2;
            this.labelWordLists.Text = "Word Lists";
            // 
            // buttonResetDefaults
            // 
            this.buttonResetDefaults.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResetDefaults.Location = new System.Drawing.Point(162, 262);
            this.buttonResetDefaults.Name = "buttonResetDefaults";
            this.buttonResetDefaults.Size = new System.Drawing.Size(200, 63);
            this.buttonResetDefaults.TabIndex = 3;
            this.buttonResetDefaults.Text = "Reset to Default";
            this.buttonResetDefaults.UseVisualStyleBackColor = true;
            this.buttonResetDefaults.Click += new System.EventHandler(this.ResetPaths);
            // 
            // listBoxWordList
            // 
            this.listBoxWordList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxWordList.FormattingEnabled = true;
            this.listBoxWordList.ItemHeight = 24;
            this.listBoxWordList.Location = new System.Drawing.Point(6, 28);
            this.listBoxWordList.Name = "listBoxWordList";
            this.listBoxWordList.Size = new System.Drawing.Size(206, 196);
            this.listBoxWordList.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(10, 299);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(199, 63);
            this.button4.TabIndex = 5;
            this.button4.Text = "Remove List";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.RemoveSelectedList);
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(617, 686);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(199, 63);
            this.buttonClose.TabIndex = 6;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.ReturnToMainMenu);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1432, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnToMainMenuToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // returnToMainMenuToolStripMenuItem
            // 
            this.returnToMainMenuToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.returnToMainMenuToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.returnToMainMenuToolStripMenuItem.Name = "returnToMainMenuToolStripMenuItem";
            this.returnToMainMenuToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.returnToMainMenuToolStripMenuItem.Text = "Return to Main Menu";
            this.returnToMainMenuToolStripMenuItem.Click += new System.EventHandler(this.ReturnToMainMenu);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxWordList);
            this.groupBox1.Controls.Add(this.buttonImportList);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(57, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 374);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manage Word Lists";
            // 
            // buttonImportList
            // 
            this.buttonImportList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImportList.Location = new System.Drawing.Point(10, 230);
            this.buttonImportList.Name = "buttonImportList";
            this.buttonImportList.Size = new System.Drawing.Size(199, 63);
            this.buttonImportList.TabIndex = 5;
            this.buttonImportList.Text = "Import List";
            this.buttonImportList.UseVisualStyleBackColor = true;
            this.buttonImportList.Click += new System.EventHandler(this.ImportNewList);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.labelResources);
            this.groupBox2.Controls.Add(this.buttonResourcesLocate);
            this.groupBox2.Controls.Add(this.buttonWordListsLocate);
            this.groupBox2.Controls.Add(this.buttonResetDefaults);
            this.groupBox2.Controls.Add(this.buttonRecordsLocate);
            this.groupBox2.Controls.Add(this.labelWordLists);
            this.groupBox2.Controls.Add(this.textBoxResourcesLocation);
            this.groupBox2.Controls.Add(this.labelRecords);
            this.groupBox2.Controls.Add(this.textBoxWordListsLocation);
            this.groupBox2.Controls.Add(this.textBoxRecordsLocation);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(709, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(529, 374);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Required Folder Custom Locations";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Only change these settings if you have relocated the required folders";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1432, 761);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonResourcesLocate;
        private System.Windows.Forms.Button buttonWordListsLocate;
        private System.Windows.Forms.Button buttonRecordsLocate;
        private System.Windows.Forms.TextBox textBoxResourcesLocation;
        private System.Windows.Forms.TextBox textBoxWordListsLocation;
        private System.Windows.Forms.TextBox textBoxRecordsLocation;
        private System.Windows.Forms.Label labelResources;
        private System.Windows.Forms.Label labelRecords;
        private System.Windows.Forms.Label labelWordLists;
        private System.Windows.Forms.Button buttonResetDefaults;
        private System.Windows.Forms.ListBox listBoxWordList;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToMainMenuToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonImportList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
    }
}
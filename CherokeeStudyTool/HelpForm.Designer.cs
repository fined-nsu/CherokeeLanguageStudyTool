﻿
namespace CherokeeLanguageLearningTool
{
    partial class HelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblHelpHeader = new System.Windows.Forms.Label();
            this.textBoxPhonetic = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSyllabary = new System.Windows.Forms.TextBox();
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
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnToFormToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // returnToFormToolStripMenuItem
            // 
            this.returnToFormToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.returnToFormToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.returnToFormToolStripMenuItem.Name = "returnToFormToolStripMenuItem";
            this.returnToFormToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.returnToFormToolStripMenuItem.Text = "Return to Main Menu";
            this.returnToFormToolStripMenuItem.Click += new System.EventHandler(this.GoToMainMenu);
            // 
            // lblHelpHeader
            // 
            this.lblHelpHeader.AutoSize = true;
            this.lblHelpHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelpHeader.Location = new System.Drawing.Point(480, 46);
            this.lblHelpHeader.Name = "lblHelpHeader";
            this.lblHelpHeader.Size = new System.Drawing.Size(463, 33);
            this.lblHelpHeader.TabIndex = 1;
            this.lblHelpHeader.Text = "Cherokee Language Learning Tool";
            this.lblHelpHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxPhonetic
            // 
            this.textBoxPhonetic.BackColor = System.Drawing.Color.LightGray;
            this.textBoxPhonetic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPhonetic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhonetic.Location = new System.Drawing.Point(320, 121);
            this.textBoxPhonetic.Multiline = true;
            this.textBoxPhonetic.Name = "textBoxPhonetic";
            this.textBoxPhonetic.ReadOnly = true;
            this.textBoxPhonetic.Size = new System.Drawing.Size(793, 267);
            this.textBoxPhonetic.TabIndex = 2;
            this.textBoxPhonetic.TabStop = false;
            this.textBoxPhonetic.Text = resources.GetString("textBoxPhonetic.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(674, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Phonetic";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(674, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Syllabary";
            // 
            // textBoxSyllabary
            // 
            this.textBoxSyllabary.BackColor = System.Drawing.Color.LightGray;
            this.textBoxSyllabary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSyllabary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSyllabary.Location = new System.Drawing.Point(320, 421);
            this.textBoxSyllabary.Multiline = true;
            this.textBoxSyllabary.Name = "textBoxSyllabary";
            this.textBoxSyllabary.ReadOnly = true;
            this.textBoxSyllabary.Size = new System.Drawing.Size(793, 245);
            this.textBoxSyllabary.TabIndex = 2;
            this.textBoxSyllabary.TabStop = false;
            this.textBoxSyllabary.Text = resources.GetString("textBoxSyllabary.Text");
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(616, 686);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(200, 63);
            this.btnClose.TabIndex = 5;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.GoToMainMenu);
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1432, 761);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSyllabary);
            this.Controls.Add(this.textBoxPhonetic);
            this.Controls.Add(this.lblHelpHeader);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "HelpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HelpForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToFormToolStripMenuItem;
        private System.Windows.Forms.Label lblHelpHeader;
        private System.Windows.Forms.TextBox textBoxPhonetic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSyllabary;
        private System.Windows.Forms.Button btnClose;
    }
}
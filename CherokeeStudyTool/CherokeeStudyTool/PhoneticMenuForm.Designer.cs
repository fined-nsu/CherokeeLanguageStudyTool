
namespace CherokeeStudyTool
{
    partial class PhoneticMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhoneticMenuForm));
            this.btnPhoneticStudy = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToMainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPhoneticAssessment = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPhoneticStudy
            // 
            this.btnPhoneticStudy.BackColor = System.Drawing.Color.White;
            this.btnPhoneticStudy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPhoneticStudy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhoneticStudy.ForeColor = System.Drawing.Color.Black;
            this.btnPhoneticStudy.Location = new System.Drawing.Point(250, 100);
            this.btnPhoneticStudy.Name = "btnPhoneticStudy";
            this.btnPhoneticStudy.Size = new System.Drawing.Size(200, 200);
            this.btnPhoneticStudy.TabIndex = 3;
            this.btnPhoneticStudy.Text = "Study";
            this.btnPhoneticStudy.UseVisualStyleBackColor = false;
            this.btnPhoneticStudy.Click += new System.EventHandler(this.btnPhoneticStudy_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1031, 24);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnToMainMenuToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
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
            this.returnToMainMenuToolStripMenuItem.Click += new System.EventHandler(this.GoToMainMenu);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.Exit);
            // 
            // btnPhoneticAssessment
            // 
            this.btnPhoneticAssessment.BackColor = System.Drawing.Color.White;
            this.btnPhoneticAssessment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPhoneticAssessment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhoneticAssessment.ForeColor = System.Drawing.Color.Black;
            this.btnPhoneticAssessment.Location = new System.Drawing.Point(580, 100);
            this.btnPhoneticAssessment.Name = "btnPhoneticAssessment";
            this.btnPhoneticAssessment.Size = new System.Drawing.Size(200, 200);
            this.btnPhoneticAssessment.TabIndex = 3;
            this.btnPhoneticAssessment.Text = "Assessment";
            this.btnPhoneticAssessment.UseVisualStyleBackColor = false;
            this.btnPhoneticAssessment.Click += new System.EventHandler(this.btnPhoneticAssessment_Click);
            // 
            // PhoneticMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1031, 461);
            this.Controls.Add(this.btnPhoneticAssessment);
            this.Controls.Add(this.btnPhoneticStudy);
            this.Controls.Add(this.menuStrip2);
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PhoneticMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cherokee Phonetic Menu";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPhoneticStudy;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToMainMenuToolStripMenuItem;
        private System.Windows.Forms.Button btnPhoneticAssessment;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}
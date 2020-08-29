namespace ACL_Master
{
    partial class frmAclMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAclMaster));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblOU = new System.Windows.Forms.Label();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.tbOU = new System.Windows.Forms.TextBox();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tbDC = new System.Windows.Forms.TextBox();
            this.lblDC = new System.Windows.Forms.Label();
            this.lblTraverseParDirectories = new System.Windows.Forms.Label();
            this.cBoxTraverse = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(454, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblOU
            // 
            this.lblOU.AutoSize = true;
            this.lblOU.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOU.Location = new System.Drawing.Point(12, 73);
            this.lblOU.Name = "lblOU";
            this.lblOU.Size = new System.Drawing.Size(39, 19);
            this.lblOU.TabIndex = 5;
            this.lblOU.Text = "OU:";
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilePath.Location = new System.Drawing.Point(12, 104);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(87, 19);
            this.lblFilePath.TabIndex = 6;
            this.lblFilePath.Text = "File Path:";
            // 
            // tbOU
            // 
            this.tbOU.Location = new System.Drawing.Point(57, 71);
            this.tbOU.Name = "tbOU";
            this.tbOU.Size = new System.Drawing.Size(383, 21);
            this.tbOU.TabIndex = 1;
            // 
            // tbFilePath
            // 
            this.tbFilePath.Location = new System.Drawing.Point(105, 104);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(335, 21);
            this.tbFilePath.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(364, 136);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(76, 28);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tbDC
            // 
            this.tbDC.Location = new System.Drawing.Point(182, 38);
            this.tbDC.Name = "tbDC";
            this.tbDC.Size = new System.Drawing.Size(258, 21);
            this.tbDC.TabIndex = 0;
            // 
            // lblDC
            // 
            this.lblDC.AutoSize = true;
            this.lblDC.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDC.Location = new System.Drawing.Point(12, 40);
            this.lblDC.Name = "lblDC";
            this.lblDC.Size = new System.Drawing.Size(164, 19);
            this.lblDC.TabIndex = 4;
            this.lblDC.Text = "Domain Controller:";
            // 
            // lblTraverseParDirectories
            // 
            this.lblTraverseParDirectories.AutoSize = true;
            this.lblTraverseParDirectories.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTraverseParDirectories.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTraverseParDirectories.Location = new System.Drawing.Point(12, 141);
            this.lblTraverseParDirectories.Name = "lblTraverseParDirectories";
            this.lblTraverseParDirectories.Size = new System.Drawing.Size(238, 19);
            this.lblTraverseParDirectories.TabIndex = 7;
            this.lblTraverseParDirectories.Text = "Traverse parent directories:";
            // 
            // cBoxTraverse
            // 
            this.cBoxTraverse.AutoSize = true;
            this.cBoxTraverse.Location = new System.Drawing.Point(256, 146);
            this.cBoxTraverse.Name = "cBoxTraverse";
            this.cBoxTraverse.Size = new System.Drawing.Size(15, 14);
            this.cBoxTraverse.TabIndex = 8;
            this.cBoxTraverse.UseVisualStyleBackColor = true;
            // 
            // frmAclMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(454, 177);
            this.Controls.Add(this.cBoxTraverse);
            this.Controls.Add(this.lblTraverseParDirectories);
            this.Controls.Add(this.lblDC);
            this.Controls.Add(this.tbDC);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbFilePath);
            this.Controls.Add(this.tbOU);
            this.Controls.Add(this.lblFilePath);
            this.Controls.Add(this.lblOU);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(470, 215);
            this.Name = "frmAclMaster";
            this.Text = "ACL Tool 0.1 - Beta";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblOU;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.TextBox tbOU;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox tbDC;
        private System.Windows.Forms.Label lblDC;
        private System.Windows.Forms.Label lblTraverseParDirectories;
        private System.Windows.Forms.CheckBox cBoxTraverse;
    }
}


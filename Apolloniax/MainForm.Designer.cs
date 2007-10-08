namespace Apolloniax {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bestandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nieuwePatiëntToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoekenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.familieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.currentPatientLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.detailMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestandToolStripMenuItem,
            this.detailMenu,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(715, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bestandToolStripMenuItem
            // 
            this.bestandToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nieuwePatiëntToolStripMenuItem,
            this.zoekenToolStripMenuItem,
            this.familieToolStripMenuItem,
            this.toolStripSeparator1,
            this.menuClose});
            this.bestandToolStripMenuItem.Name = "bestandToolStripMenuItem";
            this.bestandToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.bestandToolStripMenuItem.Text = "&Bestand";
            // 
            // nieuwePatiëntToolStripMenuItem
            // 
            this.nieuwePatiëntToolStripMenuItem.Name = "nieuwePatiëntToolStripMenuItem";
            this.nieuwePatiëntToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.nieuwePatiëntToolStripMenuItem.Text = "&Nieuwe patiënt";
            // 
            // zoekenToolStripMenuItem
            // 
            this.zoekenToolStripMenuItem.Name = "zoekenToolStripMenuItem";
            this.zoekenToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.zoekenToolStripMenuItem.Text = "Patiënt &zoeken";
            // 
            // familieToolStripMenuItem
            // 
            this.familieToolStripMenuItem.Name = "familieToolStripMenuItem";
            this.familieToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.familieToolStripMenuItem.Text = "&Familie";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(154, 6);
            // 
            // menuClose
            // 
            this.menuClose.Name = "menuClose";
            this.menuClose.Size = new System.Drawing.Size(157, 22);
            this.menuClose.Text = "&Afsluiten";
            this.menuClose.Click += new System.EventHandler(this.menuClose_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentPatientLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 385);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(715, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // currentPatientLabel
            // 
            this.currentPatientLabel.Name = "currentPatientLabel";
            this.currentPatientLabel.Size = new System.Drawing.Size(138, 17);
            this.currentPatientLabel.Text = "Geen patiënt geselecteerd.";
            // 
            // detailMenu
            // 
            this.detailMenu.Name = "detailMenu";
            this.detailMenu.Size = new System.Drawing.Size(46, 20);
            this.detailMenu.Text = "&Detail";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 407);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Apolloniax";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bestandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nieuwePatiëntToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoekenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem familieToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuClose;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel currentPatientLabel;
        private System.Windows.Forms.ToolStripMenuItem detailMenu;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}


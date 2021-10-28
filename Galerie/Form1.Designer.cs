
namespace Galerie
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonLadeBilder = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonVorheriges = new System.Windows.Forms.Button();
            this.buttonNächtes = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.NavajoWhite;
            this.pictureBox1.Location = new System.Drawing.Point(62, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonLadeBilder
            // 
            this.buttonLadeBilder.Location = new System.Drawing.Point(78, 567);
            this.buttonLadeBilder.Name = "buttonLadeBilder";
            this.buttonLadeBilder.Size = new System.Drawing.Size(75, 23);
            this.buttonLadeBilder.TabIndex = 1;
            this.buttonLadeBilder.Text = "Wähle Bilder";
            this.buttonLadeBilder.UseVisualStyleBackColor = true;
            this.buttonLadeBilder.Click += new System.EventHandler(this.buttonLadeBilder_Click);
            // 
            // buttonVorheriges
            // 
            this.buttonVorheriges.BackColor = System.Drawing.Color.Transparent;
            this.buttonVorheriges.Image = ((System.Drawing.Image)(resources.GetObject("buttonVorheriges.Image")));
            this.buttonVorheriges.Location = new System.Drawing.Point(326, 543);
            this.buttonVorheriges.Name = "buttonVorheriges";
            this.buttonVorheriges.Size = new System.Drawing.Size(92, 71);
            this.buttonVorheriges.TabIndex = 2;
            this.buttonVorheriges.UseVisualStyleBackColor = false;
            this.buttonVorheriges.Click += new System.EventHandler(this.buttonVorheriges_Click);
            // 
            // buttonNächtes
            // 
            this.buttonNächtes.BackColor = System.Drawing.Color.Transparent;
            this.buttonNächtes.Image = ((System.Drawing.Image)(resources.GetObject("buttonNächtes.Image")));
            this.buttonNächtes.Location = new System.Drawing.Point(478, 543);
            this.buttonNächtes.Name = "buttonNächtes";
            this.buttonNächtes.Size = new System.Drawing.Size(95, 71);
            this.buttonNächtes.TabIndex = 3;
            this.buttonNächtes.UseVisualStyleBackColor = false;
            this.buttonNächtes.Click += new System.EventHandler(this.buttonNächtes_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(918, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "Datei";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importierenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // importierenToolStripMenuItem
            // 
            this.importierenToolStripMenuItem.Name = "importierenToolStripMenuItem";
            this.importierenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.importierenToolStripMenuItem.Text = "Importieren";
            this.importierenToolStripMenuItem.Click += new System.EventHandler(this.importierenToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 626);
            this.Controls.Add(this.buttonNächtes);
            this.Controls.Add(this.buttonVorheriges);
            this.Controls.Add(this.buttonLadeBilder);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonLadeBilder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button buttonVorheriges;
        private System.Windows.Forms.Button buttonNächtes;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importierenToolStripMenuItem;
    }
}


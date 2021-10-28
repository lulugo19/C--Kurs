
namespace TestApp
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
            this.buttonHochzählen = new System.Windows.Forms.Button();
            this.labelZahl = new System.Windows.Forms.Label();
            this.buttonRunter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonHochzählen
            // 
            this.buttonHochzählen.BackColor = System.Drawing.Color.LightGreen;
            this.buttonHochzählen.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHochzählen.Location = new System.Drawing.Point(12, 81);
            this.buttonHochzählen.Name = "buttonHochzählen";
            this.buttonHochzählen.Size = new System.Drawing.Size(124, 43);
            this.buttonHochzählen.TabIndex = 0;
            this.buttonHochzählen.TabStop = false;
            this.buttonHochzählen.Text = "Hoch +";
            this.buttonHochzählen.UseVisualStyleBackColor = false;
            this.buttonHochzählen.Click += new System.EventHandler(this.buttonHoch_Click);
            // 
            // labelZahl
            // 
            this.labelZahl.AutoSize = true;
            this.labelZahl.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZahl.Location = new System.Drawing.Point(130, 9);
            this.labelZahl.Name = "labelZahl";
            this.labelZahl.Size = new System.Drawing.Size(41, 44);
            this.labelZahl.TabIndex = 1;
            this.labelZahl.Text = "0";
            this.labelZahl.Click += new System.EventHandler(this.labelZahl_Click);
            // 
            // buttonRunter
            // 
            this.buttonRunter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonRunter.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.buttonRunter.Location = new System.Drawing.Point(157, 81);
            this.buttonRunter.Name = "buttonRunter";
            this.buttonRunter.Size = new System.Drawing.Size(138, 43);
            this.buttonRunter.TabIndex = 2;
            this.buttonRunter.TabStop = false;
            this.buttonRunter.Text = "Runter -";
            this.buttonRunter.UseVisualStyleBackColor = false;
            this.buttonRunter.Click += new System.EventHandler(this.buttonRunter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(314, 142);
            this.Controls.Add(this.buttonRunter);
            this.Controls.Add(this.labelZahl);
            this.Controls.Add(this.buttonHochzählen);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Zähler";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonHochzählen;
        private System.Windows.Forms.Label labelZahl;
        private System.Windows.Forms.Button buttonRunter;
    }
}


﻿namespace SnippetsFast
{
    partial class File
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fileName
            // 
            this.fileName.AutoSize = true;
            this.fileName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fileName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.fileName.Location = new System.Drawing.Point(1, 1);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(61, 17);
            this.fileName.TabIndex = 0;
            this.fileName.Text = "file name";
            this.fileName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.file_onClick);
            // 
            // File
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.fileName);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "File";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Size = new System.Drawing.Size(66, 19);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label fileName;
    }
}

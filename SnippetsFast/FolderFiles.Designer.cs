namespace SnippetsFast
{
    partial class FolderFiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FolderFiles));
            this.folderName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Files = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // folderName
            // 
            this.folderName.AutoSize = true;
            this.folderName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.folderName.Location = new System.Drawing.Point(39, 13);
            this.folderName.Name = "folderName";
            this.folderName.Size = new System.Drawing.Size(92, 20);
            this.folderName.TabIndex = 1;
            this.folderName.Text = "folder name";
            this.folderName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FolderName_onClick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(30, 30);
            this.panel1.TabIndex = 2;
            // 
            // Files
            // 
            this.Files.AutoSize = true;
            this.Files.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Files.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Files.Location = new System.Drawing.Point(39, 48);
            this.Files.Name = "Files";
            this.Files.Size = new System.Drawing.Size(0, 0);
            this.Files.TabIndex = 3;
            // 
            // FolderFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.Files);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.folderName);
            this.Name = "FolderFiles";
            this.Size = new System.Drawing.Size(134, 51);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label folderName;
        private Panel panel1;
        private FlowLayoutPanel Files;
    }
}

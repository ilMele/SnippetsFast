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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FolderFiles));
            this.folderName = new System.Windows.Forms.Label();
            this.folderIconPanel = new System.Windows.Forms.Panel();
            this.Files = new System.Windows.Forms.FlowLayoutPanel();
            this.folderAreaPanel = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderAreaPanel.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // folderName
            // 
            this.folderName.AutoSize = true;
            this.folderName.BackColor = System.Drawing.Color.Transparent;
            this.folderName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.folderName.Location = new System.Drawing.Point(36, 16);
            this.folderName.Name = "folderName";
            this.folderName.Size = new System.Drawing.Size(92, 20);
            this.folderName.TabIndex = 1;
            this.folderName.Text = "folder name";
            this.folderName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FolderName_onClick);
            // 
            // folderIconPanel
            // 
            this.folderIconPanel.BackColor = System.Drawing.Color.Transparent;
            this.folderIconPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("folderIconPanel.BackgroundImage")));
            this.folderIconPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.folderIconPanel.Location = new System.Drawing.Point(3, 6);
            this.folderIconPanel.Name = "folderIconPanel";
            this.folderIconPanel.Size = new System.Drawing.Size(30, 30);
            this.folderIconPanel.TabIndex = 2;
            // 
            // Files
            // 
            this.Files.AutoSize = true;
            this.Files.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Files.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Files.Location = new System.Drawing.Point(36, 39);
            this.Files.Name = "Files";
            this.Files.Size = new System.Drawing.Size(0, 0);
            this.Files.TabIndex = 3;
            // 
            // folderAreaPanel
            // 
            this.folderAreaPanel.AutoSize = true;
            this.folderAreaPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.folderAreaPanel.Controls.Add(this.folderName);
            this.folderAreaPanel.Controls.Add(this.folderIconPanel);
            this.folderAreaPanel.Location = new System.Drawing.Point(0, 0);
            this.folderAreaPanel.Name = "folderAreaPanel";
            this.folderAreaPanel.Size = new System.Drawing.Size(131, 39);
            this.folderAreaPanel.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileToolStripMenuItem,
            this.newFolderToolStripMenuItem,
            this.deleteFolderToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(141, 70);
            // 
            // newFileToolStripMenuItem
            // 
            this.newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
            this.newFileToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.newFileToolStripMenuItem.Text = "new file";
            this.newFileToolStripMenuItem.Click += new System.EventHandler(this.stripMenu_newFile_onClick);
            // 
            // newFolderToolStripMenuItem
            // 
            this.newFolderToolStripMenuItem.Name = "newFolderToolStripMenuItem";
            this.newFolderToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.newFolderToolStripMenuItem.Text = "new folder";
            this.newFolderToolStripMenuItem.Click += new System.EventHandler(this.stripMenu_newFolder);
            // 
            // deleteFolderToolStripMenuItem
            // 
            this.deleteFolderToolStripMenuItem.Name = "deleteFolderToolStripMenuItem";
            this.deleteFolderToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.deleteFolderToolStripMenuItem.Text = "delete folder";
            this.deleteFolderToolStripMenuItem.Click += new System.EventHandler(this.stripMenu_delete);
            // 
            // FolderFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.folderAreaPanel);
            this.Controls.Add(this.Files);
            this.Name = "FolderFiles";
            this.Size = new System.Drawing.Size(134, 42);
            this.folderAreaPanel.ResumeLayout(false);
            this.folderAreaPanel.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label folderName;
        private Panel folderIconPanel;
        private FlowLayoutPanel Files;
        private Panel folderAreaPanel;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem newFileToolStripMenuItem;
        private ToolStripMenuItem newFolderToolStripMenuItem;
        private ToolStripMenuItem deleteFolderToolStripMenuItem;
    }
}

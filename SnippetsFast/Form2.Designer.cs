namespace SnippetsFast
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ListFolderFiles = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.savePanel = new System.Windows.Forms.Panel();
            this.saveLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.title_snippet = new System.Windows.Forms.Label();
            this.envName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.richText = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.savePanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ListFolderFiles);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 813);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(5, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(315, 29);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(79, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "SnippetsFast";
            // 
            // ListFolderFiles
            // 
            this.ListFolderFiles.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ListFolderFiles.Location = new System.Drawing.Point(3, 118);
            this.ListFolderFiles.Name = "ListFolderFiles";
            this.ListFolderFiles.Size = new System.Drawing.Size(320, 692);
            this.ListFolderFiles.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel2.Controls.Add(this.savePanel);
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.richText);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(326, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.panel2.Size = new System.Drawing.Size(900, 813);
            this.panel2.TabIndex = 1;
            // 
            // savePanel
            // 
            this.savePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.savePanel.Controls.Add(this.saveLabel);
            this.savePanel.Location = new System.Drawing.Point(845, 9);
            this.savePanel.Name = "savePanel";
            this.savePanel.Size = new System.Drawing.Size(43, 27);
            this.savePanel.TabIndex = 7;
            // 
            // saveLabel
            // 
            this.saveLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveLabel.Location = new System.Drawing.Point(0, 0);
            this.saveLabel.Name = "saveLabel";
            this.saveLabel.Size = new System.Drawing.Size(43, 27);
            this.saveLabel.TabIndex = 0;
            this.saveLabel.Text = "save";
            this.saveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.saveLabel_onClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.title_snippet, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.envName, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(826, 29);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // title_snippet
            // 
            this.title_snippet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.title_snippet.AutoSize = true;
            this.title_snippet.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title_snippet.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.title_snippet.Location = new System.Drawing.Point(3, 0);
            this.title_snippet.Name = "title_snippet";
            this.title_snippet.Size = new System.Drawing.Size(49, 29);
            this.title_snippet.TabIndex = 4;
            this.title_snippet.Text = "title";
            // 
            // envName
            // 
            this.envName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.envName.AutoSize = true;
            this.envName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.envName.ForeColor = System.Drawing.Color.Gainsboro;
            this.envName.Location = new System.Drawing.Point(416, 9);
            this.envName.Name = "envName";
            this.envName.Size = new System.Drawing.Size(32, 20);
            this.envName.TabIndex = 5;
            this.envName.Text = "env";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 813);
            this.panel3.TabIndex = 3;
            // 
            // richText
            // 
            this.richText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.richText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.richText.Location = new System.Drawing.Point(10, 67);
            this.richText.Name = "richText";
            this.richText.Size = new System.Drawing.Size(890, 746);
            this.richText.TabIndex = 2;
            this.richText.Text = "text";
            this.richText.TextChanged += new System.EventHandler(this.richText_onTextChange);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileToolStripMenuItem,
            this.newFolderToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // newFileToolStripMenuItem
            // 
            this.newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
            this.newFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newFileToolStripMenuItem.Text = "new file";
            this.newFileToolStripMenuItem.Click += new System.EventHandler(this.stripMenu_newFile);
            // 
            // newFolderToolStripMenuItem
            // 
            this.newFolderToolStripMenuItem.Name = "newFolderToolStripMenuItem";
            this.newFolderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newFolderToolStripMenuItem.Text = "new folder";
            this.newFolderToolStripMenuItem.Click += new System.EventHandler(this.stripMenu_newFolder);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1226, 813);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.savePanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel ListFolderFiles;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private RichTextBox richText;
        private Label title_snippet;
        private TextBox textBox1;
        private Label envName;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel savePanel;
        private Label saveLabel;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem newFileToolStripMenuItem;
        private ToolStripMenuItem newFolderToolStripMenuItem;
    }
}
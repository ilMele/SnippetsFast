﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnippetsFast
{
    public partial class File : UserControl
    {
        protected string path;
        protected Form2 editor;
        protected Action refresh;
        public File(string name, Form2 editor, Action refresh)
        {
            path = name;
            this.editor = editor;
            this.refresh = refresh;

            InitializeComponent();
            this.ContextMenuStrip = contextMenuStrip1;
            fileName.Text = Path.GetFileName(path);
        }

        private void file_onClick(object sender, MouseEventArgs e)
        {
            if(path == editor.fileEdit) { return; }

            editor.saveFlag = false;
            editor.SaveTurnGreen();
            editor.getTitleLabel().Text = fileName.Text;
            editor.getEnvLabel().Text = Path.GetFileName(Path.GetDirectoryName(path));
            editor.getRichText().Text = System.IO.File.ReadAllText(path);

            editor.fileEdit = path;
            if(!editor.getRichText().Visible) { editor.getRichText().Visible = true; }
        }

        private void stripMenu_delete(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show($"Do you want to delete {Path.GetFileName(path)}?", ":(", MessageBoxButtons.YesNo);
            if(dr == DialogResult.Yes)
            {
                System.IO.File.Delete(path);
                refresh();
            }
        }
    }
}

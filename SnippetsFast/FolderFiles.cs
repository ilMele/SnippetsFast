using System;
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
    public partial class FolderFiles : UserControl
    {
        protected Form2 editor;
        protected String path;
        protected Action refresh;
        public FolderFiles(Item item,Form2 editor, Action refresh)
        {
            this.editor = editor;
            path = item.name;
            this.refresh = refresh;

            InitializeComponent();
            this.folderAreaPanel.ContextMenuStrip = contextMenuStrip1;
            folderName.Text = Path.GetFileName(item.name);
            Files.Visible = false;
            this.load(item);
        }

        public void load(Item item)
        {
            foreach(Item i in item.items)
            {
                if(i.type)
                {
                    Files.Controls.Add(new File(i.name, editor, refresh));
                    continue;
                }
                Files.Controls.Add(new FolderFiles(i, editor, refresh));
            }
        }

        private void switchFiles()
        {
            Files.Visible = !Files.Visible;
        }

        private void FolderName_onClick(object sender, MouseEventArgs e)
        {
            switchFiles();
        }

        private void stripMenu_newFile_onClick(object sender, EventArgs e)
        {
            //Files.Controls.Add(new FileCreator(path, ref Files, true, refresh));
            switchFiles();
            new CreationWindow(path, true, refresh).ShowDialog();
        }

        private void stripMenu_newFolder(object sender, EventArgs e)
        {
            //Files.Controls.Add(new FileCreator(path, ref Files, false, refresh));
            switchFiles();
            new CreationWindow(path, false, refresh).ShowDialog();
        }

        private void stripMenu_delete(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show($"Do you want to delete the {Path.GetFileName(path)} folder and all its contents?", ":(", MessageBoxButtons.YesNo);
            if(dr == DialogResult.Yes)
            {
                Directory.Delete(path, true);
                refresh();
            }
        }
    }
}

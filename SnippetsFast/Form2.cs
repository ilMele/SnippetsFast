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
    public partial class Form2 : Form
    {
        public String fileEdit { get; set; }
        public bool saveFlag { get;  set; }
        protected SLoader sl;
        public Form2(ref SLoader sl)
        {
            this.sl = sl;
            this.fileEdit = "";
            this.saveFlag = false;

            InitializeComponent();
            this.Show();
            this.Activate();

            ListFolderFiles.ContextMenuStrip = contextMenuStrip1;
            richText.Visible = false;
            title_snippet.Text = "";
            envName.Text = "";
            
            load(this.sl.top);
        }

        public void load(Item item)
        {
            foreach(Item i in item.items)
            {
                if(i.type)
                {
                    ListFolderFiles.Controls.Add(new File(i.name, this, refresh));
                    continue;
                }
                ListFolderFiles.Controls.Add(new FolderFiles(i, this, refresh));
            }
        }

        public void refresh()
        {
            ListFolderFiles.Controls.Clear();
            sl.Load();
            load(sl.top);
        }

        public void search(Item item)
        {
            foreach (Item i in item.items)
            {
                if (i.type && Path.GetFileName(i.name).Contains(textBox1.Text))
                {
                    //Snippet s = new Snippet(Path.GetFileName(Path.GetDirectoryName(i.name)), Path.GetFileName(i.name), i.name);
                    ListFolderFiles.Controls.Add(new File(i.name, this, this.refresh));
                    continue;
                }
                search(i);
            }
        }

        private void saveLabel_onClick(object sender, MouseEventArgs e)
        {
            System.IO.File.WriteAllText(fileEdit, richText.Text);
            savePanel.BackColor = Color.LightGreen;
        }

        private void richText_onTextChange(object sender, EventArgs e)
        {
            if (saveFlag)
            {
                savePanel.BackColor = Color.OrangeRed;
            }
            saveFlag = true;
        }

        public void SaveTurnGreen()
        {
            savePanel.BackColor = Color.LightGreen;
        }

        public ref RichTextBox getRichText()
        {
            return ref this.richText;
        }

        public ref Label getTitleLabel()
        {
            return ref title_snippet;
        } 

        public ref Label getEnvLabel()
        {
            return ref envName;
        }

        private void stripMenu_newFile(object sender, EventArgs e)
        {
            new CreationWindow(sl.top.name, true, refresh).ShowDialog();
        }

        private void stripMenu_newFolder(object sender, EventArgs e)
        {
            new CreationWindow(sl.top.name, false, refresh).ShowDialog();
        }



        private void textBox_textChanged(object sender, EventArgs e)
        {
            ListFolderFiles.Controls.Clear();
            if (textBox1.Text == "")
            {
                this.load(this.sl.top);
                return;
            }
            this.search(sl.top);
        }
    }
}

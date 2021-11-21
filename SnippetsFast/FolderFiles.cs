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
        protected string folder;
        protected SLoader ffiles;
        protected RichTextBox textBox;
        protected Label titleSnippet;
        protected Label envName;
        protected Label filePath_invisible;
        protected bool textFlag;
        public FolderFiles(ref SLoader ffiles, string folder, ref RichTextBox textBox, ref Label titleSnippet, ref Label envName, ref bool textFlag)
        {
            InitializeComponent();
            this.ffiles = ffiles;
            this.folder = folder;
            this.textBox = textBox;
            this.titleSnippet = titleSnippet;
            this.envName = envName;
            this.textFlag = textFlag;

            this.folderName.Text = this.folder;
            Files.Visible = false;
            this.load();
        }

        public void load()
        {
            foreach(string file in this.ffiles.Files[folder]){
                File f = new(file, folder, ref textBox, ref titleSnippet, ref envName, ref textFlag);
                Files.Controls.Add(f);
            }
        }

        private void FolderName_onClick(object sender, MouseEventArgs e)
        {
            Files.Visible = !Files.Visible;
        }
    }
}

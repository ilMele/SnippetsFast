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
        public FolderFiles(ref SLoader ffiles, string folder)
        {
            InitializeComponent();
            this.ffiles = ffiles;
            this.folder = folder;
            this.folderName.Text = this.folder;
            Files.Visible = false;
            this.load();
        }

        public void load()
        {
            foreach(string file in this.ffiles.Files[folder]){
                File f = new(Path.GetFileName(file));
                Files.Controls.Add(f);
            }
        }

        private void FolderName_onClick(object sender, MouseEventArgs e)
        {
            Files.Visible = !Files.Visible;
        }
    }
}

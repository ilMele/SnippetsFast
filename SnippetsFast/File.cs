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
    public partial class File : UserControl
    {
        protected string path;
        public File(string name)
        {
            path = name;
            InitializeComponent();
            fileName.Text = Path.GetFileName(path);
        }

        private void file_onClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}

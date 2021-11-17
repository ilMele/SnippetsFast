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
        public File(string fileName)
        {
            InitializeComponent();
            this.fileName.Text = fileName;
        }
    }
}

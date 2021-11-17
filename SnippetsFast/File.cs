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
        protected string filePath, dirName;
        protected RichTextBox textBox;
        protected Label titleSnippet;
        protected Label envName;
        public File(string filePath, string dirName, ref RichTextBox textbox, ref Label titleSnippet, ref Label envName)
        {
            InitializeComponent();
            this.filePath = filePath;
            this.dirName = dirName;
            this.textBox = textbox;
            this.titleSnippet = titleSnippet;
            this.envName = envName;

            fileName.Text = Path.GetFileName(this.filePath);
        }

        private void file_onClick(object sender, MouseEventArgs e)
        {
            envName.Text = dirName;
            titleSnippet.Text = Path.GetFileName(filePath);
            textBox.Visible = true;
            textBox.Text = System.IO.File.ReadAllText(filePath);
        }
    }
}

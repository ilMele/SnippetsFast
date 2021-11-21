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
        protected bool textFlag;
        public File(string filePath, string dirName, ref RichTextBox textbox, ref Label titleSnippet, ref Label envName, ref bool textFlag)
        {
            InitializeComponent();
            this.filePath = filePath;
            this.dirName = dirName;
            this.textBox = textbox;
            this.titleSnippet = titleSnippet;
            this.envName = envName;
            this.textFlag = textFlag;

            fileName.Text = Path.GetFileName(this.filePath);
        }

        private void file_onClick(object sender, MouseEventArgs e)
        {
            textFlag = false;
            envName.Text = dirName;
            titleSnippet.Text = Path.GetFileName(filePath);
            textBox.AccessibleDescription = filePath;
            textBox.Text = System.IO.File.ReadAllText(filePath);
            textBox.Visible = true;
        }
    }
}

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
    public partial class FileCreator : UserControl
    {
        protected string path;
        protected FlowLayoutPanel Files;
        protected bool type;//true = create file.txt | false = create directory

        public FileCreator(string path, ref FlowLayoutPanel Files, bool type)
        {
            this.path = path;
            this.Files = Files;
            this.type = type;

            InitializeComponent();
        }

        private void textBox_keyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if(type)
                {
                    System.IO.File.Create(Path.Combine(path, textBox.Text + ".txt"));
                }else
                {
                    Directory.CreateDirectory(Path.Combine(path, textBox.Text));
                }
                
                Files.Controls.Remove(this);
            }
        }
    }
}

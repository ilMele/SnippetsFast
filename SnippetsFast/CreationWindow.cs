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
    public partial class CreationWindow : Form
    {
        protected bool type;
        protected string path;
        protected Action refresh;
        
	public CreationWindow(string path, bool type, Action refresh)
        {
            this.type = type;
            this.path = path;
            this.refresh = refresh;

            this.Name = ":(";
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                if (type)
                {
                    FileStream fs = System.IO.File.Create(Path.Combine(path, textBox1.Text + ".txt"));
                    fs.Close();
                }
                else
                {
                    Directory.CreateDirectory(Path.Combine(path, textBox1.Text));
                }
                refresh();
                this.Close();
            }
        }
    }
}

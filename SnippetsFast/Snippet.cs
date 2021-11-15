using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//icons site: https://www.flaticon.com/
namespace SnippetsFast
{
    public partial class Snippet : UserControl
    {
        public string SnpPath { get; set; }

        public Snippet()
        {
            SnpPath = "";
        }

        public Snippet(string env, string name, string snpPath)
        {
            InitializeComponent();
            this.SnpPath = snpPath;
            envsnp.Text = env;
            namesnp.Text = name;
        }
    }
}

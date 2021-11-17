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
        protected SLoader sl;
        public Form2(ref SLoader sl)
        {
            InitializeComponent();
            this.Show();
            this.Activate();

            this.sl = sl;

            load();
        }

        public void load()
        {
            foreach(KeyValuePair<string, List<string>> df in sl.Files){
                if (df.Key == "home" && df.Value.Count > 0)
                {
                    continue;
                }
                foreach(string file in df.Value)
                {
                    FolderFiles folder = new(ref this.sl, df.Key.ToString());
                    ListFolderFiles.Controls.Add(folder);
                }
            }
        }
    }
}

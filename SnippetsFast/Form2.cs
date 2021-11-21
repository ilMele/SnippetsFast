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
        protected bool textChangeFlag;
        public Form2(ref SLoader sl)
        {
            InitializeComponent();
            this.Show();
            this.Activate();

            this.sl = sl;
            this.textChangeFlag = false;

            richText.Visible = false;
            title_snippet.Text = "";
            envName.Text = "";
            
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
                    FolderFiles folder = new(ref this.sl, df.Key.ToString(), ref richText, ref title_snippet, ref envName, ref textChangeFlag);
                    ListFolderFiles.Controls.Add(folder);
                }
            }
        }

        private void saveLabel_onClick(object sender, MouseEventArgs e)
        {
            System.IO.File.WriteAllText(richText.AccessibleDescription, richText.Text);
            savePanel.BackColor = Color.LightGreen;
        }

        private void richText_onTextChange(object sender, EventArgs e)
        {
            if (!textChangeFlag ) { textChangeFlag = true;  return; }
            savePanel.BackColor = Color.OrangeRed;
        }
    }
}

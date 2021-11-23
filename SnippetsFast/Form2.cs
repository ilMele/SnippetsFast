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
        protected SLoader sl { get; set; }

        public Form2(ref SLoader sl)
        {
            InitializeComponent();
            this.Show();
            this.Activate();

            richText.Visible = false;
            title_snippet.Text = "";
            envName.Text = "";

            this.sl = sl;

            load(this.sl.top);
        }

        public void load(Item item)
        {
            if(item == sl.top)
            {
                foreach(Item f in item.items)
                {
                    if(f.items.Count == 0)
                    {
                        ListFolderFiles.Controls.Add(new File(f.name));
                    }
                }
            }

            foreach(Item i in item.items)
            {
                if(i.items.Count > 0)
                {
                    ListFolderFiles.Controls.Add(new FolderFiles(i));
                }
            }
        }

        private void saveLabel_onClick(object sender, MouseEventArgs e)
        {
            //System.IO.File.WriteAllText(richText.AccessibleDescription, richText.Text);
            savePanel.BackColor = Color.LightGreen;
        }

        private void richText_onTextChange(object sender, EventArgs e)
        {
            
        }
    }
}

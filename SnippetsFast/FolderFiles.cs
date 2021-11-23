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
    public partial class FolderFiles : UserControl
    {
        protected Form2 editor;
        public FolderFiles(Item item,Form2 editor)
        {
            this.editor = editor;
            InitializeComponent();
            folderName.Text = Path.GetFileName(item.name);
            Files.Visible = false;
            this.load(item);
        }

        public void load(Item item)
        {
            foreach(Item i in item.items)
            {
                if(i.items.Count == 0)
                {
                    Files.Controls.Add(new File(i.name, editor));
                    continue;
                }
                Files.Controls.Add(new FolderFiles(i, editor));
            }
        }

        private void FolderName_onClick(object sender, MouseEventArgs e)
        {
            Files.Visible = !Files.Visible;
        }
    }
}

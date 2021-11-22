//icons: https://www.flaticon.com/

namespace SnippetsFast
{
    public partial class Form1 : Form
    {
        protected SLoader sl;
        protected Snippet selected;
        protected bool snSelected;
        public Form1()
        {
            InitializeComponent();

            snSelected = false;
            selected = new Snippet();

            sl = new SLoader();

            notifyIcon1.Icon = Icon;
        }

        public void search(Item item)
        {
            foreach (Item i in item.items)
            {
                if (i.items.Count == 0 && i.name.Contains(textBox1.Text))
                {
                    Snippet s = new Snippet(Path.GetFileName(Path.GetDirectoryName(i.name)), Path.GetFileName(i.name), i.name);
                    flowLayoutPanel1.Controls.Add(s);
                    if (!snSelected)
                    {
                        selected = s;
                        snSelected = true;
                    }
                    continue;
                }
                search(i);
            }
        }

        private void textChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            snSelected = false;
            if (textBox1.Text != "") { search(sl.top); }
        }

        private void onKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Clipboard.SetText(System.IO.File.ReadAllText(selected.SnpPath));
                this.Hide();
                textBox1.Text = "";
            }
        }

        private void FormOnDeactivate(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void refreshButton_onClick(object sender, MouseEventArgs e)
        {
            sl.Load();
        }

        private void notifyIcon1_Click(object sender, MouseEventArgs e)
        {
            this.Show();
            this.Activate();
        }

        private void editorButton_onClick(object sender, MouseEventArgs e)
        {
            Form2 Weditor = new(ref this.sl);
        }
    }
}
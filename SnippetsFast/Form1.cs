//icons: https://www.flaticon.com/

namespace SnippetsFast
{
    public partial class Form1 : Form
    {
        protected Form2 weditor;
        protected SLoader sl;
        protected Snippet selected;
        protected bool snSelected;
        public Form1()
        {
            weditor = null;
            snSelected = false;
            sl = new SLoader();

            InitializeComponent();

            selected = new Snippet();

            notifyIcon1.Icon = Icon;
        }

        public void search(Item item)
        {
            foreach (Item i in item.items)
            {
                if (i.type && i.name.Contains(textBox1.Text))
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

        private void Weditor_FormClosed(object? sender, FormClosedEventArgs e)
        {
            weditor = null;
        }

        private void editorButton_onClick(object sender, MouseEventArgs e)
        {
            if(weditor == null)
            {
                weditor = new(ref this.sl);
                weditor.FormClosed += Weditor_FormClosed;
            }
        }
    }
}
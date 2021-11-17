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

        public void search()
        {
            if (textBox1.Text.Length < 3) { return; }

            foreach (KeyValuePair<string, List<string>> d in sl.Files)
            {
                foreach(string s in d.Value)
                {
                    if (s.Contains(textBox1.Text))
                    {
                        Snippet sn = new(d.Key, Path.GetFileName(s), s);
                        flowLayoutPanel1.Controls.Add(sn);
                        if (!snSelected)
                        {
                            selected = sn;
                            snSelected = true;
                        }
                    }
                }
            }
        }

        private void textChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            snSelected = false;
            search();
        }

        private void onKeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                Clipboard.SetText(System.IO.File.ReadAllText(selected.SnpPath));
                this.Hide();
                SendKeys.SendWait("^v");
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
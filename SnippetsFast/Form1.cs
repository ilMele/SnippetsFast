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
        }

        public void search()
        {
            if (textBox1.Text.Length < 3) { return; }

            foreach (KeyValuePair<string, string> s in sl.Files)
            {
                if (s.Value.Contains(textBox1.Text))
                {
                    Snippet sn = new(Path.GetFileName(s.Key), s.Value, s.Key + $"\\{s.Value}");
                    flowLayoutPanel1.Controls.Add(sn);
                    if (!snSelected)
                    {
                        selected = sn;
                        snSelected = true;
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
                Clipboard.SetText(File.ReadAllText(selected.SnpPath));
            }
        }
    }
}
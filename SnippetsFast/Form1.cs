namespace SnippetsFast
{
    public partial class Form1 : Form
    {
        protected SLoader sl;

        public Form1()
        {
            InitializeComponent();

            sl = new SLoader();
        }

        public void search()
        {
            foreach(KeyValuePair<string, string> s in sl.Files)
            {
                if(textBox1.Text.Length < 3) { return; }
                
                if (s.Value.Contains(textBox1.Text))
                {
                    Snippet sn = new(Path.GetFileName(s.Key), s.Value, s.Key);
                    flowLayoutPanel1.Controls.Add(sn);
                }
            }
        }

        private void textChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            search();
        }
    }
}
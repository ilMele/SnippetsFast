using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnippetsFast
{
    public class SLoader
    {
        private string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SnippetsFast";

        public Dictionary<string, List<string>> Files { get; set; }

        public SLoader()
        {
            Files = new Dictionary<string, List<string>>();

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            Load();
        }

        public void Load()
        {
            Files.Clear();

            string[] ds = Directory.GetDirectories(folderPath);

            Files.Add("home", new List<string>());
            
            foreach(string s in Directory.GetFiles(folderPath))
            {
                Files["home"].Add(s);
            }

            foreach(string d in ds) 
            {
                foreach (string f in Directory.GetFiles(d))
                {
                    string dirname = Path.GetFileName(d);
                    if (!Files.ContainsKey(dirname))
                    {
                        Files.Add(dirname, new List<string>());
                    }
                    Files[dirname].Add(f);
                }
            }
        }
    }
}

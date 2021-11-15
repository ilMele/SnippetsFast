using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnippetsFast
{
    public class SLoader
    {
        private string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Snippetsfast";

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
            string[] ds = Directory.GetDirectories(folderPath);

            foreach(string d in ds) 
            {
                foreach(string f in Directory.GetFiles(d))
                {
                    string dirname = Path.GetFileName(d);
                    if (!Files.ContainsKey(dirname)){
                        Files.Add(dirname, new List<string>());
                    }
                    Files[dirname].Add(f);
                }
            }
        }
    }
}

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

        public Dictionary<string, string> Files { get; set; }

        public SLoader()
        {
            Files = new Dictionary<string, string>();

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
                    Files.Add(d, Path.GetFileName(f));
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnippetsFast
{
    public class Item
    {
        //protected int id;
        public bool type { get; set; }
        public string name { get; set; }
        public List<Item> items { get; set; }

        public Item(string name, bool load)
        {
            this.name = name;
            this.items = new List<Item>();
            this.type = !load;
            if (load) { this.Load(name); }
        }

        public void Add(Item n)
        {
            items.Add(n);
        }

        protected void Load(string folder)
        {
            foreach (string f in Directory.GetFiles(folder))
            {
                this.Add(new Item(f, false));
            }

            foreach (string d in Directory.GetDirectories(folder))
            {
                this.Add(new Item(d, true));
            }
        }


    }

    public class SLoader
    {
        private string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SnippetsFast");
        public Item top { get; set; }

        public SLoader()
        {
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            top = new(folderPath, true);
        }

        public void Load()
        {
            top = new(folderPath, true);
        }
    }
}

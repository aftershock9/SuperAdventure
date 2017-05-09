using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    // Base class
    public class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string NamePlural { get; set; }

        public Item(int Id, string name, string namePlural)
        {
            ID = Id;
            Name = name;
            NamePlural = namePlural;
        }
    }
}
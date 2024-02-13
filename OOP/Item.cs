using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Item
    {
        public static int idCount = 0;

        public int id;
        public string title;
        public string description;
        public List<Photo> photos = new();

        public Item()
        {
            this.id = ++idCount;
        }
        public Item(string title, string description)
        {
            this.id = ++idCount;
            this.title = title;
            this.description = description;
        }

        public override string? ToString()
        {
            return $"{id} {title} {description} {photos.Count}";
        }
    }
}

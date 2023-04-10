using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Characteristics;

namespace Items
{
    public class Material :IItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Modificator<double>> GetModificators => new List<Modificator<double>>();
        public TypeItem Type => TypeItem.Material;

        public Material()
        {
            Name = string.Empty;
            Description = string.Empty;
        }

        public Material(string name, string description)
        {
            Name = name;
            Description = description;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"{Name}: {Description}");
        }
    }
}

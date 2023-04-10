using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Characteristics;

namespace Items
{
    public class Artifact:IItem
    {
        private List<Modificator<double>> modificators;
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Modificator<double>> GetModificators => modificators;
        public TypeItem Type => TypeItem.Artifact;

        public Artifact()
        {
            modificators = new List<Modificator<double>>();
            Name = string.Empty;
            Description = string.Empty;
        }
        public Artifact(Modificator<double> modificator, string name, string description)
        {

            this.modificators = new List<Modificator<double>>();
            modificators.Add(modificator);
            Name = name;
            Description = description;
        }
        public Artifact(List<Modificator<double>> modificators, string name, string description)
        {
            this.modificators = modificators;
            Name = name;
            Description = description;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"{Name}: {Description}");
        }
    }
}

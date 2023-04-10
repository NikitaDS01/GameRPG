using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Characteristics;

namespace Items
{
    public enum TypeItem
    {
        Weapon, Artifact, Material
    }
    internal interface IItem
    {
        TypeItem Type { get; }

        string Name { get; set; }

        string Description { get; set; }
        
        List<Modificator<double>> GetModificators { get; }

        void PrintInfo();
    }
}

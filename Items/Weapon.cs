﻿using Characteristics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items
{
    public class Weapon : IItem
    {
        private List<Modificator<double>> modificators;
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Modificator<double>> GetModificators => modificators;
        public TypeItem Type => TypeItem.Weapon;

        public Weapon()
        {
            modificators = new List<Modificator<double>>();
            Name = string.Empty;
            Description = string.Empty;
        }

        public Weapon(List<Modificator<double>> modificators, string name, string description)
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

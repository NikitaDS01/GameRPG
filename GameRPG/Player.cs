using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Characteristics;
using Characteristics.Parameter;

namespace GameRPG
{
    public class Player
    {
        public ParameterCollection Parameters { get; private set; }
        public Player()
        {
            Parameters = new ParameterCollection();
        }
        public Player(double health, double energy, double dexterity)
        {
            Parameters = new ParameterCollection();

            Health _health = new Health(health);
            Armor _armor = new Armor();
            Damage _damage = new Damage();
            Energy _energy = new Energy(energy);
            Dexterity _dexterity = new Dexterity(dexterity);
            Crit_Chance _critChance = new Crit_Chance();
            Crit_Damage _critDamage = new Crit_Damage();

            Parameters.Add(_health.Name, _health);
            Parameters.Add(_energy.Name, _energy);
            Parameters.Add(_armor.Name, _armor);
            Parameters.Add(_damage.Name, _damage);
            Parameters.Add(_dexterity.Name, _dexterity);
            Parameters.Add(_critChance.Name, _critChance);
            Parameters.Add(_critDamage.Name, _critDamage);
        }
        public Player(ParameterCollection parameters)
        {
            this.Parameters = parameters;
        }

        public void Update() => Parameters.Update();
        public void AddMods(Modificator<double> effect) => Parameters.AddEffect(effect);
        public void AddMods(List<Modificator<double>> effects) => Parameters.AddEffect(effects);
        public void PrintStat()
        {
            foreach (var par in Parameters.GetCollection)
            {
                Console.WriteLine($"{par.Key} - {par.Value}");
            }
        }
    }
}

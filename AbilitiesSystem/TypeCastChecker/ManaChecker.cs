using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillSystem.TypeCastChecker
{
    internal class ManaChecker : ICastChecker
    {
        public ICastChecker nextChecker {get;set;}
        public double Mana { get; set; }
        public ManaChecker(double mana)
        {
            Mana = mana;
        }
        public bool check()
        {
            if (Mana <= 0)
            {
                Console.WriteLine("Вам не хватило маны");
                return false;
            }
            else if (!(nextChecker is null))
            {
                return nextChecker.check();
            }
            return true;
        }
    }
}

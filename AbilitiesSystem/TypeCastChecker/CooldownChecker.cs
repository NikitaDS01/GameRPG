using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillSystem.TypeCastChecker
{
    internal class CooldownChecker : ICastChecker
    {
        public ICastChecker nextChecker {get;set;}
        public double CooldownValue { get; set; }
        public CooldownChecker(double cooldown)
        {
            CooldownValue = cooldown;
        }
        public bool check()
        {
            if (CooldownValue < 0)
            {
                Console.WriteLine("Скилл ещё не остыл");
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

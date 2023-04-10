using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecificationsSystem.TypeModificator
{
    public class InPercent : Modificator<decimal>
    {
        public int Percents { get; set; }
        public override int Duration { get; set; }

        public override decimal Calculate(decimal original, decimal withModificetor)
        {
            return withModificetor * Percents / 100;
        }
        public InPercent(int percents, int duration)
        {
            Percents = percents;
            Duration = duration;
        }
    }
}

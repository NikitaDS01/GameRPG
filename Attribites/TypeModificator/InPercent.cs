using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characteristics.TypeModificator
{
    public class InPercent:Modificator<double>
    {
        public int Percents { get; set; }

        public override double Calculate(double original, double withModificators)
        {
            return withModificators * Percents / 100;
        }

        public InPercent(string name, string paramName, int percents, double tickCount, bool isMaxMod=false) :base(name,paramName,tickCount, isMaxMod)
        {
            Percents = percents;
        }
    }
}

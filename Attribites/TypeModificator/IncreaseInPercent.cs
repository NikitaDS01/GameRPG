using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characteristics.TypeModificator
{
    public class IncreaseInPercent:Modificator<double>
    {
        public int Percents { get; set; }
        public int IncreasePercents { get; set; }

        public override double Calculate(double original, double withModificators)
        {
            return withModificators * Percents / 100;
        }

        public IncreaseInPercent(string name, string paramName, int percents, double tickCount, bool isMaxMod = false) : base(name, paramName, tickCount, isMaxMod)
        {
            IncreasePercents = percents;
            Percents = 100;
        }
        public override void Update()
        {
            Percents += (Percents * IncreasePercents) / 100;
            _tickCount--;
        }
    }
}

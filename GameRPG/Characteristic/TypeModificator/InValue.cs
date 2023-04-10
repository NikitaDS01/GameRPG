using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characteristics.TypeModificator
{
    public class InValue:Modificator<double>
    {
        public int Value { get; set; }

        public override double Calculate(double original, double withModificators)
        {
            return withModificators + Value;
        }

        public InValue(string name, string paramName, int value, double tickCount, bool isMaxMod = false) : base(name, paramName, tickCount, isMaxMod)
        {
            Value = value;
        }
    }
}

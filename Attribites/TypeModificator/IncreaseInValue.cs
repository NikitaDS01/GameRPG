using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characteristics.TypeModificator
{
    public class IncreaseInValue:Modificator<double>
    {
        public int Value { get; set; }
        public int IncreaseValue { get; set; }

        public override double Calculate(double original, double withModificators)
        {
            return withModificators + Value;
        }

        public IncreaseInValue(string name, string paramName, int value, double tickCount, bool isMaxMod = false) : base(name, paramName, tickCount, isMaxMod)
        {
            IncreaseValue = value;
            Value = 0;
        }
        public override void Update()
        {
            Value += IncreaseValue;
            _tickCount--;
        }
    }
}

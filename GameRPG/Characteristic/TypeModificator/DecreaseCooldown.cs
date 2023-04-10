using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characteristics.TypeModificator
{
    public class DecreaseCooldown : Modificator<double>
    {
        public int Value { get; set; }
        public int IncreaseValue { get; set; }

        public override double Calculate(double original, double withModificators)
        {
            return withModificators + Value;
        }

        public DecreaseCooldown(string name, int value, bool isMaxMod = false) : base(name, EnumParameter.COOLDOWN, value, isMaxMod)
        {
            IncreaseValue = 1;
            Value = -value;
        }
        public override void Update()
        {
            Value += IncreaseValue;
            _tickCount = -Value;
        }
    }
}

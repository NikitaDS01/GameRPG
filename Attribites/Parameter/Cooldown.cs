using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characteristics.Parameter
{
    public class Cooldown : UnitParameter
    {
        public Cooldown(double value = 0) : base(EnumParameter.COOLDOWN, value, 0)
        { }
        public Cooldown(ModificatorContainer<double> current, ModificatorContainer<double> max) : base(EnumParameter.COOLDOWN, current, max, true)
        { }
        public Cooldown(string name, ModificatorContainer<double> current, ModificatorContainer<double> max) : base(name, current, max, true)
        { }
    }
}

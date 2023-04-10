using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characteristics.Parameter
{
    public class Health : UnitParameter
    {
        public Health(double maxHealth) : base(EnumParameter.HEALTH, maxHealth, maxHealth, true) { }
        public Health(ModificatorContainer<double> current, ModificatorContainer<double> max) : base(EnumParameter.HEALTH, current, max, true)
        { }
        public Health(string name, ModificatorContainer<double> current, ModificatorContainer<double> max) : base(name, current, max, true)
        { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characteristics.Parameter
{
    public class Crit_Chance : UnitParameter
    {
        public Crit_Chance(double value = 0.01) : base(EnumParameter.CRIT_CHANCE, value, 95)
        { }
        public Crit_Chance(ModificatorContainer<double> current, ModificatorContainer<double> max) : base(EnumParameter.CRIT_CHANCE, current, max)
        { }
        public Crit_Chance(string name, ModificatorContainer<double> current, ModificatorContainer<double> max) : base(name, current, max)
        { }
    }
}

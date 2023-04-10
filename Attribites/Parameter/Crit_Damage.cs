using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characteristics.Parameter
{
    public class Crit_Damage : UnitParameter
    {
        public Crit_Damage(double value = 1.5) : base(EnumParameter.CRIT_DAMACE, value, double.PositiveInfinity)
        { }
        public Crit_Damage(ModificatorContainer<double> current, ModificatorContainer<double> max) : base(EnumParameter.CRIT_DAMACE, current, max)
        { }
        public Crit_Damage(string name, ModificatorContainer<double> current, ModificatorContainer<double> max) : base(name, current, max)
        { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characteristics.Parameter
{
    public class Damage : UnitParameter
    {
        public Damage(double value = 0) : base(EnumParameter.ATTACH, value, double.PositiveInfinity)
        { }
        public Damage(ModificatorContainer<double> current, ModificatorContainer<double> max) : base(EnumParameter.ATTACH, current, max)
        { }
        public Damage(string name, ModificatorContainer<double> current, ModificatorContainer<double> max) : base(name, current, max)
        { }
    }
}

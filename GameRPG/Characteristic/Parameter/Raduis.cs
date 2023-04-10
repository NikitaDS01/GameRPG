using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characteristics.Parameter
{
    public class Raduis : UnitParameter
    {
        public Raduis(double value = 0) : base(EnumParameter.RADUIS, value, double.PositiveInfinity)
        { }
        public Raduis(ModificatorContainer<double> current, ModificatorContainer<double> max) : base(EnumParameter.RADUIS, current, max)
        { }
        public Raduis(string name, ModificatorContainer<double> current, ModificatorContainer<double> max) : base(name, current, max)
        { }
    }
}

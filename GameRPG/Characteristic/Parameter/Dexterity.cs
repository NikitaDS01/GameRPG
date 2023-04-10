using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characteristics.Parameter
{
    public class Dexterity : UnitParameter
    {
        public Dexterity(double value) : base(EnumParameter.DEXTERITY, value, double.PositiveInfinity)
        { }
        public Dexterity(ModificatorContainer<double> current, ModificatorContainer<double> max) : base(EnumParameter.DEXTERITY, current, max)
        { }
        public Dexterity(string name, ModificatorContainer<double> current, ModificatorContainer<double> max) : base(name, current, max)
        { }
    }
}

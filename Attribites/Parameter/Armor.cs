using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characteristics.Parameter
{
    public class Armor : UnitParameter
    {
        public Armor(double value = 0) : base(EnumParameter.DEFENSE, value, 95)
        { }
        public Armor(ModificatorContainer<double> current, ModificatorContainer<double> max) : base(EnumParameter.DEFENSE, current, max)
        { }
        public Armor(string name, ModificatorContainer<double> current, ModificatorContainer<double> max) : base(name, current, max)
        { }
    }
}

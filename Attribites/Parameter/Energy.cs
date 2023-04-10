using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characteristics.Parameter
{
    public class Energy : UnitParameter
    {
        public Energy(double maxEnergy) : base(EnumParameter.ENERGY, maxEnergy, maxEnergy,true)
        { }
        public Energy(ModificatorContainer<double> current, ModificatorContainer<double> max) : base(EnumParameter.ENERGY, current, max, true)
        { }
        public Energy(string name, ModificatorContainer<double> current, ModificatorContainer<double> max) : base(name, current, max, true)
        { }
    }
}

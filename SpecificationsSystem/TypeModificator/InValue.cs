using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecificationsSystem.TypeModificator
{
    public class InValue : Modificator<decimal>
    {
        public int Value { get; set; }
        public override int Duration { get; set; }

        public override decimal Calculate(decimal original, decimal withModificetor)
        {
            return withModificetor + Value;
        }
        public InValue(int value, int duration)
        {
            Value = value;
            Duration = duration;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characteristics
{
    public class ModificatorContainer<T>
    {
        public List<Modificator<T>> Modificators { get; } // Список модификаторов
        public T OriginalValue { get; set; } // Значение без модификаторов
        // Значение с модификаторами
        public T CalculatedValue => Calculate();

        // Как модификаторы суммируются 
        private T Calculate()
        {
            return Modificators.Aggregate(OriginalValue, (current, modificator) => modificator.Calculate(OriginalValue, current));
        }

        public ModificatorContainer(T original)
        {
            this.OriginalValue = original;
            this.Modificators = new List<Modificator<T>>();
        }
    }
}

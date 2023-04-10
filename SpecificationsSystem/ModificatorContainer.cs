using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecificationsSystem
{
    public class ModificatorContainer<T>
    {
        public List<Modificator<T>> Modificators { get; }
        public T OriginalValue { get; set; }
        public T CalculatedValue => Calculate();
        private T Calculate()
        {
            return Modificators.Aggregate(OriginalValue, (current, modificator) => modificator.Calculate(OriginalValue, current));
        }
        public void Update()
        {
            for (int i = 0; i < Modificators.Count; i++)
            {
                Modificators[i].Duration -= 1;
                if (Modificators[i].Duration == 0)
                    Modificators.RemoveAt(i);
            }
        }
        public ModificatorContainer(T original)
        {
            this.OriginalValue = original;
            this.Modificators = new List<Modificator<T>>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characteristics
{
    public class ModificatorCollection
    {
        private List<Modificator<double>> modificators;
        public List<Modificator<double>> Modificators => modificators;

        public ModificatorCollection()
        {
            modificators = new List<Modificator<double>>();
        }

        public void Add(Modificator<double> value) => modificators.Add(value);
        public void Add(ModificatorCollection value) => modificators.AddRange(value.Modificators);

        public bool Remove(Modificator<double> item) => modificators.Remove(item);

        public void Clear() => modificators.Clear();

        public IEnumerator<Modificator<double>> GetEnumerator()
        {
            return modificators.GetEnumerator();
        }
    }
}

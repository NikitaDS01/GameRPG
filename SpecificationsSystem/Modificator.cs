using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecificationsSystem
{
    public abstract class Modificator<T>
    {
        public abstract int Duration {get;set;}
        public abstract T Calculate(T original, T withModificetor);
    }
}

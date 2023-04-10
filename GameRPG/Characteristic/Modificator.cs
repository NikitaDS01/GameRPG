using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characteristics
{
    public abstract class Modificator<T>
    {
        public string Name { get; private set; } //отличительное имя модификатора
        public string ParamName { get; private set; } //отличительное имя параметра
        public bool IsMaxMod { get; private set; } // модификатор на максимальное количество
        protected double _tickCount; //длительность действия эффекта в тиках
        public double LeftTicks => _tickCount;

        public Modificator(string name, string paramName, double tickCount, bool isMaxMod = false)
        {
            Name = name;
            ParamName = paramName;
            _tickCount = tickCount;
            IsMaxMod = isMaxMod;
        }

        public abstract T Calculate(T original, T withModificators);
        public virtual void Update()
        {
            //тут может быть логика для сложных эффектов, вроде увеличения эффекта со временем или вызов делегата в котором эта логика описывается.
            _tickCount--;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characteristics
{
    public class UnitParameter
    {
        /// <summary>
        /// Событие при изменение значения в параметре
        /// </summary>
        public Action<UnitParameter> ValueUpdate { get; private set; }
        /// <summary>
        /// Oтличительное имя параметра
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// Модификаторы для текущего значения параметра
        /// </summary>
        public ModificatorContainer<double> Current { get; private set; }
        /// <summary>
        /// Модификаторы для максимального значения параметра
        /// </summary>
        public ModificatorContainer<double> Max { get; private set; }
        /// <summary>
        /// Имеет ли конечное значение
        /// </summary>
        public bool IsFinite { get; set; } 
        /// <summary>
        /// Текущее значение параметра
        /// </summary>
        public double GetCurrentValue => Math.Round(Math.Min(Current.CalculatedValue,Max.CalculatedValue), 0);
        /// <summary>
        /// Максимальное значение параметра
        /// </summary>
        public double GetMaxValue => Math.Round(Max.CalculatedValue, 0);
        /// <summary>
        /// Текущее модификации на текущий параметр
        /// </summary>
        public List<Modificator<double>> CurrentMods => Current.Modificators;
        /// <summary>
        /// Текущее модификации на максимальный параметр
        /// </summary>
        public List<Modificator<double>> MaxMods => Max.Modificators;

        public UnitParameter(string name, ModificatorContainer<double> current, ModificatorContainer<double> max, bool isFinite = false)
        {
            Name = name;
            Current = current;
            Max = max;
            IsFinite = isFinite;
        }
        public UnitParameter(string name, double current, double max, bool isFinite = false)
        {
            Name = name;
            Current = new ModificatorContainer<double>(current);
            Max = new ModificatorContainer<double>(max);
            IsFinite = isFinite;
        }
        
        /// <summary>
        /// Обновляет модификаторы
        /// </summary>
        public void Update()
        {
            CurrentMods.RemoveAll(e => e.LeftTicks <= 0);
            foreach(var mods in CurrentMods)
                mods.Update();
            MaxMods.RemoveAll(e => e.LeftTicks <= 0);
            foreach (var mods in MaxMods)
                mods.Update();
        }
        public override string ToString()
        {
            if (IsFinite)
                return $"{GetCurrentValue}/{GetMaxValue}";
            else return GetCurrentValue.ToString();
        }
        /// <summary>
        /// Добавляет модификаторы для параметра
        /// </summary>
        /// <param name="effect">Модификатор</param>
        public void AddMods(Modificator<double> effect)
        {

            if (effect.IsMaxMod)
            {
                this.MaxMods.Add(effect);
            }
            else
            {
                this.CurrentMods.Add(effect);
            }
            ValueUpdate?.Invoke(this);
        }
    }
}

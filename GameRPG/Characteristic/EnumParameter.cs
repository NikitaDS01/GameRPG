using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characteristics
{
    public static class EnumParameter
    {
        /// <summary>
        /// Параметр атаки
        /// </summary>
        public static readonly string ATTACH = "ATTACH";
        /// <summary>
        /// Параметр защиты
        /// </summary>
        public static readonly string DEFENSE = "DEFENSE";
        /// <summary>
        /// Параметр критического шанса
        /// </summary>
        public static readonly string CRIT_CHANCE = "CRITCHANGE";
        /// <summary>
        /// Параметр критического урона
        /// </summary>
        public static readonly string CRIT_DAMACE = "CRITDAMAGE";
        /// <summary>
        /// Параметр ловкости
        /// </summary>
        public static readonly string DEXTERITY = "DEXTERITY";
        /// <summary>
        /// Параметр энергии
        /// </summary>
        public static readonly string ENERGY = "ENERGY";
        /// <summary>
        /// Параметр здоровья
        /// </summary>
        public static readonly string HEALTH = "HEALTH";
        /// <summary>
        /// Параметр радиуса
        /// </summary>
        public static readonly string RADUIS = "RADUIS";
        /// <summary>
        /// Параметр перезарядки оружия
        /// </summary>
        public static readonly string COOLDOWN = "COOLDOWN";
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Characteristics;

namespace GameRPG.Statuses
{
    public static class Battle
    {
        private static Player user1;
        private static Player user2;
        private static bool indicatorUser;
        public static ModificatorCollection OutputModificators { get; private set; } = new ModificatorCollection();
        public static Player ActiveUser
        {
            get
            {
                if(indicatorUser) return user1;
                return user2;
            }
        }
        public static bool IsWorks { get; private set; }
        public static void NewBatle(Player player1, Player player2)
        {
            user1 = player1;
            user2 = player2;
            OutputModificators.Clear();
            indicatorUser = true;
            IsWorks = true;
        }
        public static void ClearBatle()
        {
            user1 = null;
            user2 = null;
            OutputModificators.Clear();
            IsWorks = false;
        }
        public static void AddMods(Modificator<double> modificator)=>OutputModificators.Add(modificator);
        public static void AddMods(ModificatorCollection modificator) => OutputModificators.Add(modificator);

        private static void UpdateIndicator() => indicatorUser = !indicatorUser;
        public static void Completion()
        {
            if (IsWorks)
            {
                UpdateIndicator();
                ActiveUser.AddMods(OutputModificators);
                OutputModificators.Clear();
            }
        }

        public static void PrintBatle()
        {
            if (IsWorks)
            {
                Console.WriteLine("Игрок 1");
                user1.PrintStat();
                Console.WriteLine("\nИгрок 2");
                user2.PrintStat();
            }
            else
            {
                Console.WriteLine("Битвы нет");
            }
        }
    }
}

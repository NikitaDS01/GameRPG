using GameRPG;
using Characteristics;
using GameRPG.Command_Game;
using SkillSystem.TypeSkill;
using Characteristics.TypeModificator;
using Dialog;
using Items;
using GameRPG.Statuses;

namespace Conclusion
{
    public class MainProgram
    {
        static void Main(string[] args)
        {
            Player player1 = new Player(243, 150, 10);
            Player player2 = new Player(100, 50, 10);
            //player.AddMods(new IncreaseInPercent("Test", EnumParameter.HEALTH, 20, 3, true));
            //for (int i = 0; i < 10; i++)
            //{
            //    player.PrintStat();
            //    player.Update();
            //}
            Bomba skill = new Bomba(player1.Parameters, 25);
            //skill.ParametersSkills.AddEffect(new InPercent("IncludeRaduis", EnumParameter.RADUIS, 125, 2));
            //for (int i = 0; i < 10; i++)
            //{
            //    skill.request(player.Parameters).startRequest();
            //    skill.Update();
            //}
            Battle.NewBatle(player1, player2);
            Battle.PrintBatle();
            AttachCommand command = new AttachCommand(skill);
            command.Execute();
            Battle.PrintBatle();
        }
    }
}
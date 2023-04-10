using GameRPG;
using Characteristics;
using SkillSystem.TypeSkill;
using Characteristics.TypeModificator;
using Resource;
using Dialog;
using Items;

namespace Conclusion
{
    public class MainProgram
    {
        static void Main(string[] args)
        {
            Player player = new Player(243,150,10);
            player.AddMods(new IncreaseInPercent("Test",EnumParameter.HEALTH, 20, 3,true));
            player.AddMods(new DecreaseInValue("Test", EnumParameter.DEXTERITY, 80, 3));
            //for (int i = 0; i < 10; i++)
            //{
            //    player.PrintStat();
            //    player.Update();
            //}
            Bomba skill = new Bomba(10, 10, 100);
            skill.ParametersSkills.AddEffect(new InPercent("IncludeRaduis", EnumParameter.RADUIS, 125, 2));
            for (int i = 0; i < 10; i++)
            {
                skill.request(player.Parameters).startRequest();
                skill.Update();
            }
        }
    }

}
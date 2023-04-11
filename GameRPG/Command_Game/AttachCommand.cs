using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkillSystem;
using Characteristics;
using GameRPG.Statuses;

namespace GameRPG.Command_Game
{
    public class AttachCommand : Command
    {
        public ISkill Skill { get; private set; }
        public AttachCommand(ISkill skill)
        {
            Skill = skill;
        }
        protected override bool Run()
        {
            Skill.request.startRequest();
            Battle.Completion();
            return true;
        }
    }
}

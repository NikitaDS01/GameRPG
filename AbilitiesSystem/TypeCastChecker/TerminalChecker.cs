using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillSystem.TypeCastChecker
{
    internal class TerminalChecker : ICastChecker
    {
        public ICastChecker nextChecker { get; set; }
        ISkill skill;
        public TerminalChecker(ISkill skill)
        {
            this.skill = skill;
        }

        public bool check()
        {
            skill.cast();
            return true;
        }
    }
}

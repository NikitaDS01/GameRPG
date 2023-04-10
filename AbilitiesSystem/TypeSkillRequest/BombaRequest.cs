using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Characteristics;
using SkillSystem;
using SkillSystem.TypeCastChecker;

namespace SkillSystem.TypeSkillRequest
{
    internal class BombaRequest : ISkillCastRequest
    {
        private ICastChecker BeginChecker;

        public void cancelRequest()
        {
            throw new NotImplementedException();
        }

        public void startRequest() => BeginChecker.check();
        public BombaRequest(ISkill skill, ParameterCollection users, ParameterCollection skills)
        {
            CooldownChecker mn = new CooldownChecker(skills.GetValue(EnumParameter.COOLDOWN).GetCurrentValue);
            TerminalChecker tc = new TerminalChecker(skill);
            mn.nextChecker = tc;
            BeginChecker = mn;
        }
    }
}

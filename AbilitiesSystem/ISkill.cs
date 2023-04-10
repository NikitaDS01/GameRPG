using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Characteristics;

namespace SkillSystem
{
    public interface ISkill
    {
        UnitParameter GetCooldown { get; }
        void cast();
        void Update();
        ISkillCastRequest request(ParameterCollection parametersUsers);
        ParameterCollection ParametersSkills { get; }
    }
}

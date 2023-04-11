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
        void cast();
        void Update();
        ISkillCastRequest request { get; }
        ParameterCollection ParametersSkills { get; }
        string OutputText { get; }
    }
}

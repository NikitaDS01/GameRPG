using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Characteristics;

namespace SkillSystem
{
    public interface ISkillCastRequest
    {
        void startRequest();
        void cancelRequest();
    }
}

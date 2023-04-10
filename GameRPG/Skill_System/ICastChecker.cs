using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillSystem
{
    public interface ICastChecker
    {
        ICastChecker nextChecker { get; set; }
        bool check();
    }
}

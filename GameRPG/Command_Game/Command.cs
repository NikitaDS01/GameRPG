using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPG.Command_Game
{
    public abstract class Command
    {
        public bool IsValid { get; private set; }

        public Command Execute()
        {
            IsValid = Run();
            return this;
        }

        protected abstract bool Run();
    }
}

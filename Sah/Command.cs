using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorWithCommand
{
    public abstract class Command
    {
        public abstract void Execute();
        public abstract void UnExecute();
    }
}

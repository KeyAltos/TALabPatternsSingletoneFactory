using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternSingletoneFactory
{
    public class IncorrectAppConfigDriverType: Exception
    {
        public IncorrectAppConfigDriverType(string message) : base(message) { }        
    }
}

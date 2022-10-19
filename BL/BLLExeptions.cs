using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BLLExeptions
    {
        public class NotPassedValueException : Exception
        {
            public override string Message => "Vallue do not pass to format!";
        }
    }
}

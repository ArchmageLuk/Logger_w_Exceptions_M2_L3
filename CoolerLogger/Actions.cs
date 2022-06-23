using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolerLogger
{
    
    public class Actions
    {
        public bool Flag;
        public Result logstring = new Result();

        public bool InfoMethod()
        {
            Flag = true;
            return Flag;
        }

        public bool WarningMethod()
        {
            Flag = true;
            throw new BusinessException();
        }

        public bool ErrorMethod()
        {
            Flag = false;
            throw new Exception();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolerLogger
{
    public class BusinessException : Exception
    {
        public string ExMessage = "Action got this custom Exception: ";
    }
}

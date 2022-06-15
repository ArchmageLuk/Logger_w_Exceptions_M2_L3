using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolerLogger
{
    public class Result
    {
        public void CreateLog(string message, string type, DateTime time)
        {
            string result = $"{time}: {type} : {message}";
            new Logger().ConsoleLog(result);
        }
    }
}

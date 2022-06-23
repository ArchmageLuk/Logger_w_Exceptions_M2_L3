using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolerLogger
{  

    public class Result
    {
        public DateTime Time = DateTime.UtcNow.AddHours(3);

        public string CreateLog(string? exmess, string message, string type)
        {
            string result = $"{exmess}{Time}: {type} : {message}";
            new Logger().ConsoleLog(result);
            return result;
        }
    }
}

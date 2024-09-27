using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolerLogger
{
    public class Logger
    {
        public void ConsoleLog(string resultlog)
        {
            Console.WriteLine(resultlog);
        }

        public void WriteIntoFile(string[] wholelog)
        {
            new FileService().WriteInFile(wholelog);
        }
    }
}

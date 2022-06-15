using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolerLogger
{
    public class Logger
    {

        public string[] Newlog = new string[100];
        public void ConsoleLog(string resultlog)
        {
            Console.WriteLine(resultlog);
            for (int i = 0; i < Newlog.Length; i++)
            {
                if (string.IsNullOrEmpty(Newlog[i]))
                {
                    Newlog[i] = resultlog;
                }
            }
        }

        public void WriteInFile()
        {
            string[] wholelog = Newlog;
            new FileService().WriteInFile(wholelog);
        }
    }
}

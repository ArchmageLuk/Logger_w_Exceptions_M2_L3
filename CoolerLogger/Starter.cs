using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolerLogger
{
    public class Starter
    {
        public void Run()
        {
            for (int i = 0; i < 100; i++)
            {
                int whatmethod = new Random().Next(1, 4);
                if (whatmethod == 1)
                {
                    new Actions().InfoMethod();
                }
                else if (whatmethod == 2)
                {
                    new Actions().WarningMethod();
                }
                else if (whatmethod == 3)
                {
                    new Actions().ErrorMethod();
                }
            }

            new Logger().WriteInFile();
        }
    }
}
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
            string[] newLog = new string[100];
            for (int i = 0; i < 100; i++)
            {
                Result resultlog = new Result();
                int whatmethod = new Random().Next(1, 4);
                if (whatmethod == 1)
                {
                    new Actions().InfoMethod();
                    Console.WriteLine(" ");
                    string logstring = resultlog.CreateLog(null, "Start method: 'InfoMethod'", "Info");
                    newLog[i] = logstring;
                }
                else if (whatmethod == 2)
                {
                    try
                    {
                        new Actions().WarningMethod();
                    }
                    catch (BusinessException ex)
                    {                        
                        Console.WriteLine(" ");
                        string logstring = resultlog.CreateLog(ex.ExMessage, "Skipped logic in method", "Warning");
                        newLog[i] = logstring;
                        Console.WriteLine(ex.Message);
                    }
                }
                else if (whatmethod == 3)
                {
                    try
                    {
                        new Actions().ErrorMethod();
                    }
                    catch (Exception ex)
                    {
                        string exmessage = "Action failed by a reason: ";
                        Console.WriteLine(" ");
                        string logstring = resultlog.CreateLog(exmessage, "I broke a logic", "Error");
                        newLog[i] = logstring;
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            new Logger().WriteIntoFile(newLog);
        }
    }
}
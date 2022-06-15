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
        public string? ResultMessage;
        public string? Message;
        public string? Type;
        public DateTime Time = DateTime.UtcNow.AddHours(3);
        Result logstring = new Result();

        public bool InfoMethod()
        {
            
            Message = "Start method:";
            Type = "Info";
            Flag = true;
            logstring.CreateLog(Message, Type, Time);
            return Flag;
        }

        public bool WarningMethod()
        {
            Message = "Start method:";
            Type = "Warning";
            Flag = true;
            logstring.CreateLog(Message, Type, Time);
            return Flag;
        }

        public bool ErrorMethod()
        {
            Message = "Start method:";
            Type = "Error";
            Flag = false;
            logstring.CreateLog(Message, Type, Time);
            return Flag;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace CoolerLogger
{
    public class Deserialize
    {
        public void Deserialization()
        {
            var configFile = File.ReadAllText(@"D:\Проекти\Навчання С+\Код\Logger_w_Exceptions\CoolerLogger\Configs\configservice.json");
            var config = JsonConvert.DeserializeObject<Config>(configFile);
        }
    }
}
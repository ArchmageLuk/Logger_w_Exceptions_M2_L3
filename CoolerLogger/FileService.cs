using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CoolerLogger
{
    public class FileService
    {
        public string DirectoryPath { get; set; }

        public void WriteInFile(string[] resultlog)
        {

            //reads path from json file
            string readingJson = File.ReadAllText(@"D:\Projects\C# learning\Code\Logger_w_Exceptions\CoolerLogger\Configs\configservice.json");
            var jsonDir = JsonConvert.DeserializeObject<FileService>(readingJson);
            string directoryPath = jsonDir.DirectoryPath;

            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(directoryPath);

            // Creates an asseptable filename
            string filename = new Result().Time.ToString();
            char[] chars = filename.ToCharArray(); 
            for(int i = 0; i < chars.Length; i++)
            {
                if (Char.IsDigit(chars[i]))
                {
                    continue;
                }
                else
                {
                    chars[i] = '_';
                }
            }
            filename = new string(chars);

            //Counting and deletion of files
            int count = dir.GetFiles().Length;
            if (count < 3)
            {
                File.WriteAllLines($"{directoryPath}{filename}.txt", resultlog);
            }
            else
            {
                //Searches for oldest file from 3
                FileInfo[] oldchek = dir.GetFiles();
                var oldestfile = oldchek[0].FullName;

                if (oldchek[0].CreationTimeUtc < oldchek[1].CreationTimeUtc & oldchek[0].CreationTimeUtc < oldchek[2].CreationTimeUtc)
                {
                    oldestfile = oldchek[0].FullName;
                }
                else if (oldchek[1].CreationTimeUtc < oldchek[2].CreationTimeUtc)
                {
                    oldestfile = oldchek[1].FullName;
                }
                else
                {
                    oldestfile = oldchek[2].FullName;
                }

                //Deletes oldest file and creates new one
                File.Delete(oldestfile);
                File.WriteAllLines($"{directoryPath}{filename}.txt", resultlog);
            }
           
        }
    }
}

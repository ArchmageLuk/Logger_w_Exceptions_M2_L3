using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolerLogger
{
    public class FileService
    {
        public void WriteInFile(string[] resultlog)
        {
            string filename = new Actions().Time.ToString();
            string path = @"D:\Проекти\Навчання С+\Код\Logger_w_Exceptions\CoolerLogger\Logfiles\";
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(path);

            // Changes forbidden symbols in generated file name for underscore
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

            //Count and deletion of files
            int count = dir.GetFiles().Length;
            if (count < 3)
            {
                File.AppendAllLines($"{path}{filename}.txt", resultlog);
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
                File.AppendAllLines($"{path}{filename}.txt", resultlog);
            }
           
        }
    }
}

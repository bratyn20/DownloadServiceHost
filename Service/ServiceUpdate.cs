using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Service
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "ServiceUpdate" в коде и файле конфигурации.
    public class ServiceUpdate : IServiceUpdate
    {

        
        public Stream getFile(string way)
        {

            // string path = @"c:\0000\testPOU.docx";
            string path = @way;
            FileStream file = File.Open(path, FileMode.Open);
            return file;
        }

        string appPath = AppDomain.CurrentDomain.BaseDirectory;

        public string[] getFileinfo()
        {
         //   Console.WriteLine(appPath);
            Directory.CreateDirectory(appPath + "Download");
            string[] filename = Directory.GetFiles(appPath + "Download");
            Console.WriteLine("Файлы на передачу: \n");
            for (int i = 0; i < filename.Length; i++)
            {
                Console.WriteLine(filename[i]);
            }
                //string[] files = Directory.GetFiles(@"c:\0000");
            return filename;
        }

        public int LenghtFile(string way)
        {
            int lenght = 0;
            // string path = @"c:\0000\testPOU.docx";
            string path = @way;
            FileStream file = File.Open(path, FileMode.Open);
            lenght = (int)file.Length;
            file.Close();

            return lenght;
        }

    //    public string Update()
     //   {
    //        Console.WriteLine("Пришло сообщение");
    //        return "Privet";
    //    }

        
    }
}

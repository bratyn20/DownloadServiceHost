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
            string path = @appPath + "Download\\" + way;
            FileStream file = File.Open(path, FileMode.Open);
            return file;
        }

        string appPath = AppDomain.CurrentDomain.BaseDirectory;
        //Directory.CreateDirectory(appPath + "Download");
         //   string[] filename = Directory.GetFiles(appPath + "Download");

        public string[] getFileinfo()
        {
            //   Console.WriteLine(appPath);
            Directory.CreateDirectory(appPath + "Download");
            string[] filename = Directory.GetFiles(appPath + "Download");

            List<string> filename1 = new List<string>();
           /* for(int i=0; i<filename.Length; i++)
            {
                filename1.Add(Path.GetFileName(filename[i]));
            }*/

           
            //string[] files = Directory.GetFiles(@"c:\0000");
            WayDir(appPath + "Download",filename1);
           // string[] filename3 = filename1.ToArray();
           // fille.Clear();
            string[] filename2 = filename1.ToArray();
            Console.WriteLine("Файлы на передачу: \n");

            List<string> qq = new List<string>();

            for (int i = 0; i < filename2.Length; i++)
            {
                string[] q = filename2[i].Split(new[] { "\\Download\\" }, StringSplitOptions.None);
                qq.Add(q[1]);
                Console.WriteLine(q[1] + "\n");
            }

            string[] filename3 = qq.ToArray();
            return filename3;
        }

        public int LenghtFile(string way)
        {
           // Directory.CreateDirectory(appPath + "Download");
            int lenght = 0;
            // string path = @"c:\0000\testPOU.docx";
            string path = @appPath + "Download\\" + way;
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

      

        public static void WayDir(string FromDir, List<string> fileway) //На вход методу подаётся путь откуда копируем и куда копируем
        {
           // Directory.CreateDirectory(ToDir);
            foreach (string s1 in Directory.GetFiles(FromDir))
            {
                // string s2 = ToDir + "\\" + System.IO.Path.GetFileName(s1);
                // File.Copy(s1, s2, true);
                // List<string> file9 = new List<string>();
                //fille.Add(s1);
                fileway.Add(s1);
            }
            foreach (string s in Directory.GetDirectories(FromDir))
            {
                WayDir(s,fileway);
            }

        }
    }
}

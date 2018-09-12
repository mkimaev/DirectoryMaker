using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DirectoryMaker
{
    class DirMaker
    {
        public string Result { get; set; }
        public DirMaker() { }
        public void CreateDirectory(string dirName)
        {
            string[] data3 = TKD.dataTkd.Split('*');
            //dirName = "MDU_KHA00078";
            //string pathDir = @"D:\MDU_Kharkiv_cluster";
            string pathDir = Environment.CurrentDirectory;
            DirectoryInfo dirInfo = new DirectoryInfo(pathDir);
            var item = from t in data3
                       where t.Contains(dirName)
                       //select t.TrimStart(new char {'\','r\n' });
                       select t;
            foreach (string mytkd in item)
            {
                string mytkd2 = mytkd.Substring(2);
                string subpath = dirName + "\\" + mytkd2;

                if (!dirInfo.Exists)
                {
                    dirInfo.Create();
                }

                try
                {
                    dirInfo.CreateSubdirectory(subpath);
                    Result = String.Format("Папки по {0} созданы. Путь {1}", dirName, pathDir);
                }
                catch (Exception e)
                {
                    Result = e.Message;
                }
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInfo_WindowsForm
{
    class UserInfo
    {
        public string UserName;
        private System.DateTime _lastModified;
        public void Save()
        {
            System.IO.StreamWriter sw = new System.IO.StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\UserInfo.txt");
            sw.WriteLine(UserName);
            sw.WriteLine(DateTime.Now.ToString());
            sw.Close();

        }

        public void Read()
        {

            string file = AppDomain.CurrentDomain.BaseDirectory + "\\UserInfo.txt";

            if (System.IO.File.Exists(file))
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(file);
                UserName = sr.ReadLine();
                _lastModified = DateTime.Parse(sr.ReadLine());
                sr.Close();
            }

        }

    }
}

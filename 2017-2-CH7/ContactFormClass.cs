using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Happy
{
    class ContactForm
    {
        public int ID;
        public string myName;
        public int myGender { get; set; } //不用加分號
        public void PrintData()=>Console.WriteLine($"姓名:{myName},座號:{ID},性別:{myGender}");
        public void PrintData(string room)=>Console.WriteLine($"{room} 姓名:{myName},座號:{ID},性別:{myGender}");

        

    }
}

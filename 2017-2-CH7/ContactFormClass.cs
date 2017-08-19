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

    public class Book
    {
        private int id;
        private int Name;
        private int ISBN;

        //多型-繼承多形-覆寫
        public virtual void Read() {
            Console.WriteLine("閱讀方式，虛擬方法 交給繼承者覆寫(override)");
        }
    }

    public class magazine : Book
    {

        public override void Read()
        {
            Console.WriteLine("雜誌，每月固定時間提供紙本閱讀");
        }
       

    }

    public class ebook : Book
    {
        public override void Read()
        {
            Console.WriteLine("電子書，以下載方式提供閱讀");
        }
    }

    public class schoolbook : Book
    {
        public override void Read()
        {
            Console.WriteLine("教科書，由學校統一發放提供閱讀");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_2_CH7
{
    class Program
    {
        static void Main(string[] args)
        {

            //(1)類別複習
            Happy.ContactForm Jesse = new Happy.ContactForm();
            Jesse.ID = 1;
            Jesse.myName = "Jesse";
            Jesse.myGender = 1;
            Jesse.PrintData();
            Jesse.PrintData("三年三班");

            //簡易宣告寫法
            Happy.ContactForm Mary= new Happy.ContactForm {ID=2,myName="Mary",myGender=2 };
            Mary.PrintData("三年四班");

                    }
    }
}

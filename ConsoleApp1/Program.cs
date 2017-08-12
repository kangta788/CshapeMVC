using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        public enum Gender
        {
            男,女,男中女,女中男,非男女
                //也可以不宣告數字 會自動排序
        }

        static void Main(string[] args)
        {

            //資料型別轉換 加入新的字串串接方法(好用不是?)
            string inputString;
            inputString = "2018/8/12 08:24:55";
            Console.WriteLine($"inputString= {inputString}");

            DateTime myDate;
            myDate = Convert.ToDateTime(inputString);

            Console.WriteLine($"一般時間顯示方式: {myDate.ToString()}");
            Console.WriteLine($"簡短時間顯示方式: {myDate.ToShortDateString()}");


            //再次練習列舉 要常用

            company myConpany = company.亞馬遜;
            Console.WriteLine($"我的公司是{myConpany}");


            //注意軒個列舉的位置
            Gender mygender = Gender.女中男;
            Console.WriteLine($"我的性別是{mygender}");



        }
    }
}

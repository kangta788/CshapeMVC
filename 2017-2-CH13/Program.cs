using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_2_CH13
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Jesse","Marry","Jonh"};

            //(1)select * from names

            var result = from s in names
                         select s;
            //注意:result是一個IEnumerable的物件 所以可以用for each印出所有內容
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("======================================");
            //(2)select * from names where 開頭是J
            var result2 = from s in names
                          where s.StartsWith("J")
                         select s;
            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("======================================");
            //(3)select k from nmnse group by 字母 having k.count>2

            var result3 = from s in names
                          group s by s[0] into k
                          where k.Count() >= 2
                          select k;
            foreach (var item in result3)
            {
                Console.WriteLine(item.Key);
               
            }

            Console.WriteLine("======================================");

            //(4)轉換型別
            var result4 = from s in names
                          select s.Length;

            //(5)匿名型別



            //(6)用匿名型別一次回傳多個
            //select 
            var result5 = from s in names
                          select new { Name = s, Length = s.Length };
            Console.WriteLine("======================================");

            //(7)P25 用Lamda寫


            Console.WriteLine("======================================");
            //(8)自行練習


            Console.WriteLine("======================================");
            //(9)銜接資料庫(曹老師部分)




        }
    }
}

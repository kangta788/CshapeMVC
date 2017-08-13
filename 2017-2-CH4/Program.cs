using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_2_CH4
{
    class Program
    {
        static void Main(string[] args)
        {

            //陣列幾個進階用法
            int[] numbersArray = { 8, 1, 0, 0, 7, 7, 3, 2 };

            for (int i = 0; i < numbersArray.Length; i++)
            {
                Console.WriteLine($"原始陣列:{numbersArray[i]}");
            }


            Array.Sort(numbersArray);//排序

            for (int i = 0; i < numbersArray.Length; i++)
            {
                Console.WriteLine($"排序後陣列:{numbersArray[i]}");
            }

            // GetUpperBound的用法(未研究)


            Console.WriteLine("=====================================");

            //複習集合


            //集合-ArrayList 大小可改變 型別可不同
            //上課錄影影片:https://www.youtube.com/watch?v=dMFXaOExgPw

            ArrayList ar = new ArrayList();

            ar.Add("Hello");
            ar.Add(1000);
            ar.Add(true);
            Console.WriteLine($"ArrayList的大小:{ar.Count}");
            Console.WriteLine($"ArrayList在記憶體(Heap區)配置的大小:{ar.Capacity}");


            ar.Add(1);
            Console.WriteLine($"ArrayList的大小:{ar.Count}");
            Console.WriteLine($"ArrayList在記憶體(Heap區)配置的大小:{ar.Capacity}");

            ar.Add(1);
            Console.WriteLine($"ArrayList的大小:{ar.Count}");
            Console.WriteLine($"ArrayList在記憶體(Heap區)配置的大小:{ar.Capacity}");

            ar.Add(1);
            Console.WriteLine($"ArrayList的大小:{ar.Count}");
            Console.WriteLine($"ArrayList在記憶體(Heap區)配置的大小:{ar.Capacity}");

            Console.Write("顯示所有的物件");
            foreach (var item in ar)
            {
                Console.Write(item + ",");
            }
            Console.WriteLine();
            Console.WriteLine("=====================================");

            //集合-HashTable  建立時慢 但搜尋快
            //上課錄影影片(HashTable的原理):https://www.youtube.com/watch?v=Vxi7QY99Mao&t=1s

            Hashtable movie = new Hashtable() {
                {"7:00", "電影1" },
                {"8:00", "電影2" },
                {"9:00", "電影3" }
            };
            movie.Add("10:00", "電影4");
            movie.Add("11:00", "電影5");
            movie.Add("12:00", "電影5");
            movie.Add("13:00", "電影7");

            Console.WriteLine($"movie[\"12:00\"]={movie["12:00"]}");
            //顯示movie["12:00"]=電影5

            //直接修改
            movie["12:00"] = "電影6";
            Console.WriteLine($"movie[\"12:00\"]={movie["12:00"]}");

            Console.WriteLine("=====================================");

            //System.Collections.Concurrent 命名空間
            //https://msdn.microsoft.com/zh-tw/library/system.collections.concurrent(v=vs.110).aspx
            //提供數個安全執行緒集合類別，每當有多個執行緒同時存取集合時，應該使用這些類別來代替 System.Collections 和 System.Collections.Generic 命名空間中的對應類型。
            //但透過目前集合實作之其中一個介面進行存取的成員(包含擴充方法)，都不保證會是安全執行緒，且可能需要由呼叫端同步。


            Console.WriteLine("=====================================");



            //泛型
            //影片(好處與效能):https://www.youtube.com/watch?v=sGj6zIVuxEw

            List<string> stringList = new List<string>();//注意要括號
            stringList.Add("Apple");
            stringList.Add("Pizza");
            stringList.Add("New Youk");
            stringList.Add("Central Park");
            stringList.Add("BoardCast");


            Console.Write("泛型List<T> 列出所有的字串:");
            foreach (var item in stringList)
            {
                Console.Write(item + ",");
            }

            Console.WriteLine();


            List<int> intList = new List<int>() { 4, 8, 9, 6, 3, 2, 5, 9, 12, 5, 3, 9, 5 };
            intList.Sort();
            Console.Write("泛型List<T> 列出所有的數字並排序:");
            foreach (var item in intList)
            {
                Console.Write(item + ",");
            }

            Console.WriteLine();
            Console.WriteLine("=====================================");

            //HashTable的泛型:Dictionary
            //影片:https://youtu.be/sTYC5lq08gI

            Dictionary<int, string> d = new Dictionary<int, string>  //()可省略
            {
                {1,"王" },{2,"李"},{3,"陳"},{4,"簡"}

            };
            Console.WriteLine($"d[1]={d[1]}");

            Console.WriteLine("=====================================");


        }
    }
}

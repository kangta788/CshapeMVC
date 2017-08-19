using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_2_CH6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.參數進階:ref、out、選擇性參數 參數陣列 

            //1-1選擇性參數
            Echo();//未輸入名字就會顯示unknow
            Echo("Jesse");

            Echo2("Jesse");//年齡預設18
            Echo2("Jesse",33);

            //1-2 ref out 參數

            //1-3 參數陣列
            Console.WriteLine(AllNameString("Jesse","Mary","Peter","John","Tom"));
            Console.WriteLine(AllNameString("Monmin", "Aplace"));

            //2 ValueTuple與Nuget的安裝方式
            //https://msdn.microsoft.com/zh-tw/library/system.valuetuple(v=vs.110).aspx
            //https://www.nuget.org/packages/System.ValueTuple/
            //Install-Package System.ValueTuple -Version 4.4.0

            //上課影片:https://www.youtube.com/watch?v=dI088gaqTEY

            var rect = (800, 500);
            Console.WriteLine(rect.Item1);
            Console.WriteLine(rect.Item2);

            var rect2 = (a:800, b:500);
            Console.WriteLine(rect.a);
            Console.WriteLine(rect.b);


            var r = RectAB(3, 6);//呼叫valuetuple型別的方法 可以回傳多個值
            Console.WriteLine(r.A);
            Console.WriteLine(r.B);

            //3 用StringBulder來串字串
            StringBuilder e = new StringBuilder();
            e.Append("X");
            e.Append("Y");
            e.Append("Z,");
            e.Append("X");
            
            //string+ 和 stringBuilder的效能討論
            //http://blog.darkthread.net/post-2007-12-15-stringbuilder-for-static-string-concate.aspx
            //https://dotblogs.com.tw/jeff-yeh/2008/11/04/5870
        }

        //1-1 選擇性參數
        static void Echo(string name = "unknow")
        {
            Console.WriteLine($"My name is:{name}");

        }
        static void Echo2(string name,int age=18)//注意 選擇性參數要在後面
        {
            Console.WriteLine($"My name is:{name}，{age} years old");

        }

        //1-2 ref out參數
        //static void Echo3(out int Cyear)
        //{
        //    Cyear = Cyear+1911;

        //}

        //1-3參數陣列
        static string AllNameString(params string[] Namelist)
        {
            return $"總共有{Namelist.Length}個人，名單是{string.Join(",",Namelist)}";
        }

        //2 valueTuple方法 可回傳多個值
        static (int A,int B)RectAB(int i,int j)
        {
            return (i+j,i-j);//會回傳一個(int A,int B)的tuple
        }



    }
}

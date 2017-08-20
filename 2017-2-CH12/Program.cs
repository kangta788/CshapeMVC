using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_2_CH12
{

    //建立委派類別(必要)
    public delegate void MyDelegate1(string s);


    class Program
    {

        static void Main(string[] args)
        {
            //(0)課本原始舊用法 P12-8 12-9頁 
            //略 直接用新的語法

            //(1)改用匿名方法呼叫 方法內容寫在後面 方法名稱可以省略
            MyDelegate1 d1 = delegate (string s) { Console.WriteLine($"F1=>{s}"); };

            //(2)提升到Lamda寫法呼叫匿名方法

            //影片:https://www.youtube.com/watch?v=_UzGeK3LDwU
            // 左邊:參數 => 右邊:執行程式碼
            MyDelegate1 d2 = (s) => Console.WriteLine($"F1=>{s}");

            //(3)(s)的括弧可省略
            MyDelegate1 d3 = s => Console.WriteLine($"F1=>{s}");

            //(4)用Action delegate再簡化的寫法，把上面第11行加入
            //影片:https://www.youtube.com/watch?v=NPZBDVllFCc
            Action<string> d4 = s => Console.WriteLine($"F1=>{s}"); //此寫法可以省略第11行的宣告 示最終簡化寫法


            //(5)用Func delegate 可回傳值
            //影片:https://www.youtube.com/watch?v=lvro1c5NOn4
            Func<int, int, int> d5 = (x, y) => x + y;
            Console.WriteLine(d5(10, 20));
            //試想 delegate的原始用意是甚麼?
            //一般來說 委派要在多個類別中溝通才有意義
            //他是事件的基礎 因為事件會穿過多個類別互相呼叫
        }


    }


}

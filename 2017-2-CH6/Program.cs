using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_2_CH6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add("1", "3"));


            //泛型方法:以下兩行都是呼叫同一支方法 改良過去的overload
            Console.WriteLine(Add2(1, 3));//印出4
            Console.WriteLine(Add2("1", "3"));//印出13

        }

        //(1)C# 6.0新語法 簡化有回傳值的方法 但僅限只有一行的方法
        static string Add(string X, string Y) => X + Y;

        //(2)泛型方法:加設多個方法要做的事情一樣(如:X+Y)，但有可能傳入不同型別的參數
        //過去是用overload的方式，現在可以改由泛行方法來處理，減少重複程式碼(DRY)
        //影片:https://www.youtube.com/watch?v=DGnLavb85Xg

        static T Add2<T>(T x,T y)  //T為某種型別 
        {
            dynamic i = x; //因為不知道他實際的型別 所以動態產生(跟var有何不同??)
            dynamic j = y;
            return i + j;

        }
    }
}

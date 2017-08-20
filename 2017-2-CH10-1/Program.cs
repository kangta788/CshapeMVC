using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_2_CH10_1
{
    //定義抽象類別
    public abstract class Vehicle
    {

        //抽象成員 不用實作 後面不用有東西
        public abstract int Wheels { get; }
        public abstract void Run();


        //實體成員 有實作
        public string ID;
        public void DisplayInfo() {
            Console.WriteLine($"ID:{this.ID},Wheels:{this.Wheels}");
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

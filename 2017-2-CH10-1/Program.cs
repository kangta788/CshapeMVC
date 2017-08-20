using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_2_CH10_1
{

    public abstract class Vehicle
    {

        //抽象成員
        public abstract int Wheels { get; }
        public abstract void Run();


        //實體成員
        public string ID;
        public void DisplayInfo();

    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_2_CH10_2
{

    //Main
    class Program
    {
        static void Main(string[] args)
        {
            magazine VOGUE = new magazine();
            VOGUE.id = 1;
            VOGUE.Name = "VOGUE 8月號 2017 第251期";
            VOGUE.magazineType = "時尚";
            VOGUE.ISBN = "977102800000608";
            VOGUE.Read();


            boarder schoolboard = new boarder();
            schoolboard.Read();

        }
    }
}

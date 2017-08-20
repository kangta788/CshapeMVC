using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2017_2_CH9
{


    //(1)靜態成員
    class Employee
    {
        public static string Company = "NMNS";
        public static string GetCompany()
        {
            return Company;
        }
    }

    //(2)擴充方法-為String結構新增一個Print方法和ISEmail方法
    static class Extensions
    {
        public static void Print(this String ss)
        {
            Console.WriteLine(ss);
        }

        public static bool IsEmail(this string ee)
        {
            Regex r = new Regex("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$");//Email
            return r.IsMatch(ee);
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            //(1)靜態成員 方法
            Console.WriteLine(Employee.Company);
            Console.WriteLine(Employee.GetCompany());


            //(2)擴充方法Print()

            "Apple".Print();
            Employee.Company.Print();

            //(3)擴充方法ISEmail()
            Console.WriteLine("kangta788@yahoo.com.tw".IsEmail());
            Console.WriteLine("kangta788@yahoo".IsEmail());
            Console.WriteLine("@yahoo.com.tw".IsEmail());



        }
    }
}

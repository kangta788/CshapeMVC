using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinApp_ch9
{
    class Books
    {
        public Books() {
            this.bookname = "999";
            this.bookprice = 999;
        }
        public Books(string name,int price)
        {
            this.bookname = name;
            this.bookprice = price;
        }

        public string bookname;
        public int bookprice;
        public string getInfo()
        {
            return string.Format("書名:{0},價格:{1}", this.bookname, this.bookprice);
        }

        ~Books()
        {
            Console.WriteLine("再會了我的朋友!!!");
        }

    }

    class Books2:IDisposable  //Ch9 P11有時等GC來收時效率不佳 可明確釋放資源 寫大數據的程式時要注意
    {
        public Books2()
        {
            this.bookname = "999";
            this.bookprice = 999;
        }
        public Books2(string name, int price)
        {
            this.bookname = name;
            this.bookprice = price;
        }

        public string bookname;
        public int bookprice;
        public string getInfo()
        {
            return string.Format("書名:{0},價格:{1}", this.bookname, this.bookprice);
        }

        public void Dispose() //ch9 p11明確釋放資源
        {
            Console.WriteLine("Dispose:再會了我的朋友!!!");
            GC.SuppressFinalize(this);
        }

        ~Books2()
        {
            Console.WriteLine("GC:再會了我的朋友!!!");
        }

    }
}

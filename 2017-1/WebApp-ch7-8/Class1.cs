using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NMNS.libery//p29 命名空間的用法
{
    public partial class Books //p24 -25部分類別的用法 另一部分在class2.cs
    {
        public string BookName; //欄位 開放對外存取
        private string _ISBN;//屬性 透過get/set機制存取 欄位不對外公開
        private int _price;//屬性 透過get/set機制存取 欄位不對外公開

        public string ISBN
        {
            get { return this._ISBN; }
            set { this._ISBN = value; }
        }
        public int Price //不讓人直接存取_price 透過這道門來管控 也可設定唯讀寫的狀態
        {
            get { return this._price; }
            set
            {
                if (value > 0)
                {
                    this._price = value;
                }
                else { this._price = 0; }
            }
        }

        //方法 對外公開
        public string getinfo()
        {
            return string.Format("書名:{0},ISBN:{1},價格:{2}", this.BookName, this._ISBN, this._price);

        }
        public string getinfo(string sep) //overload 可以用列舉讓人來選要哪一種分隔符號
        {
            return string.Format("書名:{0}{3}ISBN:{1}{3}價格:{2}", this.BookName, this._ISBN, this._price, sep);

        }

    }

    public struct LittleBooks
    {
        public string bookName;
        public string bookISBN;
        public int bookPrice;
        public string getInfo() {
            return string.Format("書名:{0},ISBN:{1},價格:{1}", this.bookName, this.bookISBN, this.bookPrice);
        }

    }
}
using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace NMNS.libery
{
    public class MainStore
    {
        private int _balance=0;
        private string _bookName;
        private int Balance
        {
            get
            {
                return this._balance;
            }

            set
            {
                this._balance = value;
            }
        }
        public string BookName
        {
            get
            {
                return this._bookName;
            }

            set
            {
                this._bookName = value;
            }
        }
        public virtual string getInfo()
        {
            return string.Format("書ID:{0},庫存量:{1}", this.BookName, this.Balance);
        }
        public void inBook(int n)
        {
            this.Balance += n;//不直接修改欄位_balance,而是透過屬性Balance來修改
        }
        public void outBook(int n)
        {
            this.Balance -= n;
        }
    }

    public class Store1 : MainStore
    {
        public string storename;

        public override string getInfo()
        {
            return base.getInfo() + "店名:" + this.storename;//部分改寫
        }

    }

    public class Store2 : MainStore
    {
        public string storename;

        public override string getInfo()
        {
            return string.Format("分店名稱:{0},書名:{1},現有庫存:{2}", this.storename, base.BookName);
        }

    }

}
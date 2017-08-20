using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_2_CH10_2
{
    //定義抽象類別Book
    public abstract class Book
    {
        //1.實體成員
        public int id;
        public string Name;
        public string ISBN;
        //1-1.實體成員 給後代覆寫virtual
        public virtual void Read()
        {
            Console.WriteLine("閱讀方式，虛擬方法 交給繼承者覆寫(override)");
        }

        //1-2.抽象成員
        //先省略


    }

    //2.繼承Book的字類別們

    public class magazine : Book, IRead  //冒號後面接[父類別][抽象類別][介面]
    {
        public magazine() //建構子
        {
            Console.WriteLine("建立了一本雜誌");
        }

        //繼承父類別的欄位 id、Name、ISBN

        public string magazineType { get; set; }//雜誌自備(非繼承)屬性

        public override void Read()
        {
            Console.WriteLine($"{magazineType}雜誌:{Name}，每月固定時間提供紙本閱讀");
            this.OpenBook();
            this.ReadBook();
            this.CloseBook();

        }

        public void OpenBook()
        {
            //實際定義介面 要有明確定義 三個都要定義不能漏掉
            Console.WriteLine($"{magazineType}雜誌:{Name}，開始翻開閱讀");
        }
        public void ReadBook()
        {
            //實作介面 要有明確定義
            Console.WriteLine($"{magazineType}雜誌:{Name}，閱讀雜誌內容");
        }
        public void CloseBook()
        {
            //實作介面 要有明確定義
            Console.WriteLine($"{magazineType}雜誌:{Name}，闔上雜誌");
        }



    }

    public class boarder : IRead
    {
        public boarder()
        {
            Console.WriteLine("看到牆上有一則公布欄");

        }

        public void Read()
        {
            OpenBook();
            ReadBook();
            CloseBook();

        }

        public void OpenBook()
        {
            //實際定義介面 要有明確定義 三個都要定義不能漏掉
            Console.WriteLine($"開始找出布告欄起始點");
        }
        public void ReadBook()
        {
            //實作介面 要有明確定義
            Console.WriteLine($"閱讀布告欄內容");
        }
        public void CloseBook()
        {
            //實作介面 要有明確定義
            Console.WriteLine($"看完布告欄");
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_2_CH10_2
{
    //2.定義介面(閱讀行為) 不可有{實作內容} 成員前面public可省略
    public interface IRead
    { 
        void OpenBook();
        void ReadBook();
        void CloseBook();

    }

}

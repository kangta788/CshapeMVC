using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH2_1.Models
{
    public class Opera
    {
        [DisplayName("編號")]
        public int OperaID { get; set; }


        [DisplayName("歌劇名稱")]
        public string Title { get; set; }


        [DisplayName("年分")]
        [CheckValidYear] //p2-18
        public int? Year { get; set; } //P2-4頁 MVC中常用到的NULLABLE型別 方便做opction


        [DisplayName("作者")]
        public string Composer { get; set; }
    }
}

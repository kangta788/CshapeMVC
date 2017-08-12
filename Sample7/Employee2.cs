using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompnay
{
    public partial class Employee
    {
        public void SetHireDate(DateTime hireDate)
        {
            this.hireDate = hireDate;
        }
        public void SetHireDate(String hireDate)
        {
            this.hireDate = DateTime.Parse(hireDate);
        }
        public void SetHireDate(int year, int month, int day)
        {
            this.hireDate = new DateTime(year, month, day);
        }

        public String GetBirthDate()
        {
            return this.birthDate.ToString("d");
        }
        public String GetBirthDate(DateType type)
        {
            string result = "";
            switch (type)
            {
                case DateType.Calendar:
                    result = this.birthDate.ToString("d");
                    break;
                case DateType.ChineseCalendar:
                    //System.Globalization.TaiwanCalendar
                    TaiwanCalendar c1 = new TaiwanCalendar();
                    int y = c1.GetYear(this.birthDate);
                    int m = c1.GetMonth(this.birthDate);
                    int d = c1.GetDayOfMonth(this.birthDate);
                    result = String.Format("{0:000}/{1:00}/{2:00}", y, m, d);
                    break;
                case DateType.ChineseLunisolar:
                    //System.Globalization.TaiwanLunisolarCalendar
                    TaiwanLunisolarCalendar c2 = new TaiwanLunisolarCalendar();
                    int y2 = c2.GetYear(this.birthDate);
                    int m2 = c2.GetMonth(this.birthDate);
                    int d2 = c2.GetDayOfMonth(this.birthDate);
                    result = String.Format("{0:000}/{1:00}/{2:00}", y2, m2, d2);
                    break;
                default:
                    break;
            }
            return result;
        }
        public String GetBirthDate(DateType type, DateFormat format)
        {
            string result = "";
            switch (type)
            {
                case DateType.Calendar:
                    result = (format == DateFormat.ShortDate) ? this.birthDate.ToString("d") : this.birthDate.ToString("D");
                    break;
                case DateType.ChineseCalendar:
                    //System.Globalization.TaiwanCalendar
                    TaiwanCalendar c1 = new TaiwanCalendar();
                    int y = c1.GetYear(this.birthDate);
                    int m = c1.GetMonth(this.birthDate);
                    int d = c1.GetDayOfMonth(this.birthDate);
                    result = (format == DateFormat.ShortDate) ? String.Format("{0:000}/{1:00}/{2:00}", y, m, d) : String.Format("民國{0}年{1}月{2}日", y, m, d);
                    break;
                case DateType.ChineseLunisolar:
                    //System.Globalization.TaiwanLunisolarCalendar
                    TaiwanLunisolarCalendar c2 = new TaiwanLunisolarCalendar();
                    int y2 = c2.GetYear(this.birthDate);
                    int m2 = c2.GetMonth(this.birthDate);
                    int d2 = c2.GetDayOfMonth(this.birthDate);
                    result = (format == DateFormat.ShortDate) ? String.Format("{0:000}/{1:00}/{2:00}", y2, m2, d2) : String.Format("農曆{0}年{1}月{2}日", y2, m2, d2);
                    break;
                default:
                    break;
            }
            return result;
        }

    }
    public enum DateFormat
    {
        LongDate,
        ShortDate
    }

    public enum DateType
    {
        Calendar,
        ChineseCalendar,
        ChineseLunisolar
    }
}

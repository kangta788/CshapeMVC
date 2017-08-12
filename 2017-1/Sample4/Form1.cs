using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] myInt = new int[3];
            myInt[0] = 1;
            myInt[1] = 2;
            myInt[2] = 3;
            //myInt[3] = 4;
            //System.IndexOutOfRangeException was unhandled
            //Message=Index was outside the bounds of the array.
            MessageBox.Show(myInt[0].ToString(), myInt.Length.ToString());

            string result = "";
            for (int i = 0; i < myInt.Length ; i++)
            {
                result += myInt[i].ToString() + "\t";

            }
            MessageBox.Show(result, myInt.Rank.ToString());

            int[] myInt2 = { 1, 2, 3 };
            result = "";
            foreach (var item in myInt2 )
            {
                result += item.ToString() + "\n";
            }
            MessageBox.Show(result, myInt2.Rank.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[,] myInt = new int[3, 2];//==>3x2=6
            myInt[0, 0] = 1;
            myInt[0, 1] = 2;
            myInt[1, 0] = 3;
            myInt[1, 1] = 4;
            myInt[2, 0] = 5;
            myInt[2, 1] = 6;
            string result = "";
            for (int i = 0; i < myInt.GetLength(0); i++)
            {
                for (int j = 0; j < myInt.GetLength(1); j++)
                {
                    result = result + myInt[i, j] + "\t";
                }

            }
            MessageBox.Show(result, myInt.Rank.ToString());

            int[,] myInt2 = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            //System.Text.StringBuilder 
            StringBuilder sb = new StringBuilder();
            foreach (int item in myInt2)
            {
                sb.AppendLine(item.ToString());
            }
            result = sb.ToString();
            MessageBox.Show(result, myInt2.Rank.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //不規則
            string[][] schedule = new string[12][];

            schedule[0] = new string[31];

            if (DateTime.IsLeapYear(DateTime.Now.Year))
            {
                schedule[1] = new string[29];
            }
            else
            {
                schedule[1] = new string[28];
            }

            schedule[2] = new string[31];
            schedule[3] = new string[30];
            schedule[4] = new string[31];
            schedule[5] = new string[30];
            schedule[6] = new string[31];
            schedule[7] = new string[31];
            schedule[8] = new string[30];
            schedule[9] = new string[31];
            schedule[10] = new string[30];
            schedule[11] = new string[31];

            schedule[9][9] = "十月十日國慶日";
            schedule[0][0] = "一月一日元旦";

            MessageBox.Show(schedule[9][9], String.Format("Rank:{0},Length:{1}", schedule.Rank, schedule.Length));

            int count=0;
            for (int i = 0; i < schedule.Length; i++)
            {
                count += schedule[i].Length;
            }
            MessageBox.Show(String.Format("Length:{0}",count ));
        }

        private void button5_Click(object sender, EventArgs e)
        {

            int[] i = { 1, 2, 3 };
            //不可直接擴大
            //i = new int[5];
            //MessageBox.Show(i[0].ToString());

            //1.建立新的陣列實體
            int[] j = new int[5];
            //2.將原資料複製到新陣列中
            Array.Copy(i, j, i.Length);
            //3.修改陣列變數的參考
            i = j;

            string result = "";
            StringBuilder sb = new StringBuilder();
            foreach (int item in i)
            {
                sb.Append(item.ToString() + "\t");
            }
            result = sb.ToString();
            MessageBox.Show(result, i.Length.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //錯誤寫法
            int[] i = { 1, 2, 3 };
            int[] j = i;
            j[0] = 11;
            MessageBox.Show(i[0].ToString(), j[0].ToString());

            //1.使用Array.Copy複製陣列(可決定複製長度)
            int[] i2 = { 1, 2, 3 };
            int[] j2 = new int[i2.Length];
            Array.Copy(i2, j2, i2.Length);
            j2[0] = 11;
            MessageBox.Show(i2[0].ToString(), j2[0].ToString());

            //2.使用Clone()複製陣列(完整複製)
            int[] i3 = { 1, 2, 3 };
            int[] j3 = (int[])i3.Clone();
            j3[0] = 22;
            MessageBox.Show(i3[0].ToString(), j3[0].ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //using System.Collections;
            ArrayList al = new ArrayList();
            //Add(Value)
            al.Add("Zero");//al[0]  
            al.Add(1);//al[1]
            al.Add(true);//al[2]
            al.Add(DateTime.Now);//al[3]
            al.Add('@');//al[4]
            //AddRange(Array|Collection)
            int[] i = { 1, 2, 3, 4, 5 };
            al.AddRange(i);//al[5~9]
            //Insert(Index,Value)
            al.Insert(2, "TWO");//al[2]==>al[3](true)

            string result = "";
            StringBuilder sb = new StringBuilder();
            foreach (var item in al)
            {
                sb.AppendLine(item.ToString());
            }
            result = sb.ToString();
            MessageBox.Show(result, string.Format("數量:{0},依內建索引排列(新增順序)", al.Count));

            al.Remove(1);//Remove(value)
            al.RemoveAt(0);//RemoveAt(Index)
            sb.Clear();
            foreach (var item in al)
            {
                sb.AppendLine(item.ToString() + ":" + item.GetType().ToString());
            }

            result = sb.ToString();
            MessageBox.Show(result, string.Format("數量:{0},依內建索引排列(新增順序)", al.Count));
            //Clear()-->All
            al.Clear();
            MessageBox.Show(string.Format("數量:{0}", al.Count));
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //表示物件的先進先出 (FIFO) 集合。
            //System.Collections.Queue
            Queue q = new Queue();
            //Enqueue將物件加入 Queue 的末端。
            q.Enqueue("A");//A
            q.Enqueue("B");//A.B
            q.Enqueue("C");//A.B.C
            q.Enqueue("D");//A.B.C.D
            q.Enqueue("E");//A.B.C.D.E
            //Dequeue移除並傳回在 Queue 底端的物件。
            MessageBox.Show("Peek:" + q.Peek().ToString(), "Count:" + q.Count.ToString());
            //先進先出(old)  
            q.Dequeue(); //B.C.D.E(移除A)
            q.Dequeue(); //C.D.E(移除B)

            string result = "";
            StringBuilder sb = new StringBuilder();
            foreach (var item in q)
            {
                sb.AppendLine(item.ToString() + ":" + item.GetType().ToString());
            }
            result = sb.ToString();
            MessageBox.Show(result, string.Format("數量:{0}，OLD:{1},依新增順序排列(ＦＩＦＯ)", q.Count, q.Peek()));

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //代表由物件組成的後進先出 (LIFO) 簡單非泛型集合。
            //System.Collections.Stack
            Stack st = new Stack();
            //新增至底端
            st.Push("A"); //A
            st.Push("B"); //B.A
            st.Push("C"); //C.B.A
            st.Push("D"); //D.C.B.A
            st.Push("E"); //E.D.C.B.A
            //
            MessageBox.Show("Peek:" + st.Peek().ToString(), "Count" + st.Count.ToString());
            //從New移除
            st.Pop(); //D.C.B.A(移除E)
            st.Pop(); //C.B.A(移除D)
            string result = "";
            StringBuilder sb = new StringBuilder();
            foreach (var item in st)
            {
                sb.AppendLine(item.ToString() + ":" + item.GetType().ToString());
            }
            result = sb.ToString();
            MessageBox.Show(result, string.Format("數量:{0}，底端:{1},依新增反順序排列(ＬＩＦＯ)", st.Count, st.Peek()));

        }

        private void button13_Click(object sender, EventArgs e)
        {
            //System.Collections.Hashtable
            Hashtable ht = new Hashtable();
            ht.Add("Zero", 0);//(Key,Value)
            ht.Add("One", 1);
            ht.Add("Two", "2");
            ht.Add("Three", "3");
            ht.Add("Four", 4);
            MessageBox.Show(ht["Zero"].ToString());

            //ht.Add("Four",44);//1.Key需有唯一性Unique
            //System.ArgumentException was unhandled==>  Message="Item has already been added. Key in dictionary: '4'  Key being added: '4'"

            //ht.Add(null, "Null"); //2.Key不可null
            //System.ArgumentNullException was unhandled

            ht.Add("5", null);//3.值可允許null
            ht.Add("0", 0);//3.值可重覆
            ht.Remove("Zero");//Remove(Key)

            StringBuilder sb = new StringBuilder();
            //System.Collections.DictionaryEntry 
            foreach (DictionaryEntry item in ht)
            {
                sb.Append(item.Key + "\t" + item.Value + "\n");
            }
            MessageBox.Show(sb.ToString(), string.Format("數量:{0},依Hash Key排列", ht.Count));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //System.Collections.ArrayList
            // ArrayList al = new ArrayList();

            //System.Collections.Generic.List<T>
            List<int> al = new List<int>();
            //Add(Value)
            al.Add(0);
            al.Add(1);
            al.Add(2);
            al.Add(3);
            al.Add(4);
            //al.Add("Zero");
            //Error CS1503  Argument 1: cannot convert from 'string' to 'int'   WindowsFormsApplication4 C:\temp\Sample4\WindowsFormsApplication4\Form1.cs   296

            //AddRange(Array|Collection)
            int[] i = { 6, 7, 8, 9, 10 };
            al.AddRange(i);
            //Insert(Index,Value)
            al.Insert(5, 5);

            string result = "";
            StringBuilder sb = new StringBuilder();
            foreach (int item in al)
            {
                sb.AppendLine(item.ToString() + ":" + item.GetType().ToString());
            }
            result = sb.ToString();
            MessageBox.Show(result, string.Format("數量:{0},依內建索引排列(新增順序)", al.Count));

        }

        private void button10_Click(object sender, EventArgs e)
        {
            //表示物件的先進先出 (FIFO) 。
            //System.Collections.Generic.Queue 
            Queue<string> q = new Queue<string>();
            //Enqueue將物件加入 Queue 的末端。
            q.Enqueue("A");//A
            q.Enqueue("B");//A.B
            q.Enqueue("C");//A.B.C
            q.Enqueue("D");//A.B.C.D
            q.Enqueue("E");//A.B.C.D.E

            string result = "";
            StringBuilder sb = new StringBuilder();
            foreach (string item in q)
            {
                sb.Append(item + "\t");
            }
            result = sb.ToString();
            MessageBox.Show(result, string.Format("數量:{0}，頂端:{1},依新增順序排列(ＦＩＦＯ)", q.Count, q.Peek()));


        }

        private void button11_Click(object sender, EventArgs e)
        {
            //代表由物件組成的後進先出 (LIFO) 泛型。
            //System.Collections.Generic.Stack
            Stack<string> st = new Stack<string>();
            //新增至頂端
            st.Push("A"); //A
            st.Push("B"); //B.A
            st.Push("C"); //C.B.A
            st.Push("D"); //D.C.B.A
            st.Push("E"); //E.D.C.B.A

            string result = "";
            StringBuilder sb = new StringBuilder();
            foreach (string item in st)
            {
                sb.Append(item + "\t");
            }
            result = sb.ToString();
            MessageBox.Show(result, string.Format("數量:{0}，頂端:{1},依新增反順序排列(ＬＩＦＯ)", st.Count, st.Peek()));

        }

        private void button12_Click(object sender, EventArgs e)
        {
            //System.Collections.Generic.Dictionary 
            Dictionary<string, int?> ht = new Dictionary<string, int?>();
            ht.Add("Zero", 0);//(Key,Value)
            ht.Add("One", 1);
            ht.Add("Two", 2);
            ht.Add("Three", 3);
            ht.Add("Four", 4);
            ht.Add("5", null);//值可允許null
            StringBuilder sb = new StringBuilder();
            //System.Collections.Generic.KeyValuePair
            foreach (KeyValuePair<string, int?> item in ht)
            {
                sb.Append(item.Key + "\t" + item.Value + "\n");
            }
            MessageBox.Show(sb.ToString(), string.Format("數量:{0},依Key新增順序排列", ht.Count));
        }
    }
}

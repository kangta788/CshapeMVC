using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp_ch6
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "方法";
        }
        //清空listbox
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        //1.基本function與c呼叫
        private void button1_Click(object sender, EventArgs e)
        {
            string result = getTotal(int.Parse(textBox1.Text));
            MessageBox.Show(result);
        }

        /// <summary>
        /// 輸入一值給文字欄位，則會計算出1到該數值的總和
        /// </summary>
        /// <param name="n">輸入一個數值</param>
        /// <returns>傳回1-n的總和</returns>
        string getTotal(int n)
        {
            int sum = 0;
            for (int i = 0; i <= n; i++)
            {
                sum += i;
            }
            return string.Format("1加到{0}的總和為:{1}", n, sum);
        }


        //2.新語法-具名參數
        private void button3_Click(object sender, EventArgs e)
        {
            string result = gettotal2(b: 20, a: 30, c: 50);
            MessageBox.Show(result);
        }

        string gettotal2(int a, int b, int c)
        {
            string result = "a=" + a + ",b=" + b + ",c=" + c + ",a+b+c=" + (a + b + c);
            return result;
        }

        //3.新語法-選擇性傳入參數
        private void button4_Click(object sender, EventArgs e)
        {
            string result = gettotal3();
            MessageBox.Show(result);
        }

        /// <summary>
        /// 呼叫此函式的參數可選擇性輸入
        /// </summary>
        /// <param name="a">選擇性輸入，不輸入預設為0</param>
        /// <param name="b">選擇性輸入，不輸入預設為0</param>
        /// <param name="c">選擇性輸入，不輸入預設為0</param>
        /// <returns>傳回一段文字</returns>
        string gettotal3(int a = 0, int b = 0, int c = 0)
        {
            string result = "a=" + a + ",b=" + b + ",c=" + c + ",a+b+c=" + (a + b + c);
            return result;
        }

        //4.輸出參數(取代return的寫法)
        private void button5_Click(object sender, EventArgs e)
        {
            int x;
            Test_OUT(out x);
            MessageBox.Show(x.ToString());
        }
        /// <summary>
        /// 輸出參數練習
        /// </summary>
        /// <param name="i"></param>
        void Test_OUT(out int i) { i = 100; }

        //5.傳值與傳址(重要)
        private void button6_Click(object sender, EventArgs e)
        {
            int x = 0;
            Test_ByValuse(x);
            MessageBox.Show(x.ToString());
        }
        private void button7_Click(object sender, EventArgs e)
        {
            int x = 0;
            Test_ByRenfrence(ref x);
            MessageBox.Show(x.ToString());
        }
        /// <summary>
        /// 傳值:呼叫此function後，x的值就被傳過去，x就被留著不用
        /// </summary>
        /// <param name="i">接收x傳來的值</param>
        void Test_ByValuse(int i) { i = i + 1; }
        /// <summary>
        /// 傳址:呼叫此function後，x仍具主導地位，提供位址給別人，讓別人繼續使用他的值
        /// </summary>
        /// <param name="i">只是x的代理人</param>
        void Test_ByRenfrence(ref int i) { i = i + 1; }



        //6.陣列參數(兩種 一種為傳入時已經是陣列 另一種直接把數列傳入 自動轉成陣列處理)
        private void button8_Click(object sender, EventArgs e)
        {
            int[] nn = { 30, 40, 50, 60 };
            int result = Sum_params1(nn);//一定要傳入陣列才可以
            MessageBox.Show(result.ToString());
        }
        private void button9_Click(object sender, EventArgs e)
        {
            int result = Sum_params2(30,40,50,60);//只要是多組數值都可傳入
            MessageBox.Show(result.ToString());
        }

        int Sum_params1(int[] numbers) { return numbers.Sum(); }
        int Sum_params2(params int[] numbers) { return numbers.Sum(); }

        //7.(1).練習String.join功能 (2).陣列排序
        private void button11_Click(object sender, EventArgs e)
        {
            int[] nn = { 30, 70, 50, 60 };
            MessageBox.Show(string.Join(",",nn));

        }
        private void button12_Click(object sender, EventArgs e)
        {
            int[] nn = { 30, 70, 50, 60 };
            //nn.Sort();
            MessageBox.Show(string.Join(",", nn));
        }
        //資料的格式化 以toString為延伸的用法


        //樂透 
        private void button10_Click(object sender, EventArgs e)
        {

        }


    }
}

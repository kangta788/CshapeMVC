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

namespace WindowsProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi, " + textBox1.Text);
            MessageBox.Show("2");
        }

        private void ppap(object sender, EventArgs e)
        {
            MessageBox.Show("PPAP");

            Random r = new Random();
            int ppap = r.Next(1, 4);
            if (ppap == 1)
            {
                MessageBox.Show("Pen");
                // pictureBox1.Image = Image.FromFile("../pen.jpg");
            }
            else if (ppap == 2)
            {
                MessageBox.Show("Apple");
            }
            else
            {
                MessageBox.Show("Pinapple");
            }

        }
        int a = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            a++;
            label1.Text = a.ToString();
            if (a > 10) { a = 1; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int total = Convert.ToInt32(textBox2.Text) * 5;
            MessageBox.Show("total=" + total);
            //if input 20A->會產生EXCEPTION
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int total = int.Parse(textBox2.Text) * 5;
            MessageBox.Show("total=" + total);
            //if input 20A->會產生EXCEPTION
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int total;
            string s = textBox2.Text;

            //避免處理EXCEPTION的方法
            if (int.TryParse(s, out total))
            {
                MessageBox.Show("total=" + (total * 5));
            }
            else
            {
                MessageBox.Show("input the NUMBER please!!!");
            }
        }

        const string CompanyName = "NMNS";

        private void Form1_Load(object sender, EventArgs e)
        {
            EmpolyLevel JobTitle;
            JobTitle = EmpolyLevel.研究員;
            this.Text = CompanyName + " " + JobTitle.ToString() + " " + JobTitle.GetHashCode();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int[] scores = new int[6];
            scores[0] = 64;
            scores[1] = 98;
            scores[2] = 84;
            scores[3] = 56;
            scores[4] = 99;
            scores[5] = 43;

            for (int i = 0; i < scores.Length; i++)
            {
                //listBox1.Items.Add("score["+i+"]="+scores[i]);
                listBox1.Items.Add(string.Format("scroe[{0}]={1}", i, scores[i]));
            }
            listBox1.Items.Add("-----------------");
            foreach (int x in scores)
            {
                listBox1.Items.Add(x);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            string[,] schoolClass = { { "一年甲班", "一年乙班" }
                                     , { "二年甲班", "二年乙班" }
                                     , { "三年甲班", "三年乙班" } };

            for (int i = 0; i < schoolClass.GetLength(0); i++)
            {
                for (int j = 0; j < schoolClass.GetLength(1); j++)
                {
                    listBox1.Items.Add(string.Format("schoolClass[{0},{1}]={2}", i, j, schoolClass[i, j]));
                }
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int[][] scorce = new int[3][];
            scorce[0] = new int[1] { 1 };
            scorce[1] = new int[2] { 1, 2 };
            scorce[2] = new int[3] { 1, 2, 3 };
            for (int i = 0; i < scorce.Length; i++)
            {

                foreach (int item in scorce[i])
                {
                    listBox1.Items.Add(item);
                }



            }




        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            ArrayList al = new ArrayList();
            al.Add("王大明");
            al.Add(856);
            al.Add("歡迎光您哈囉你好嗎");

            foreach (var item in al)
            {
                listBox1.Items.Add(item);
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Hashtable ht = new Hashtable();
            ht.Add(100, "小名");
            ht.Add(200, "讀者文摘");
            ht.Add("蘋果", "PPAP");

            foreach (var k in ht.Keys)
            {
                listBox1.Items.Add(string.Format("ht[{0}]={1}", k, ht[k]));
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<int> LS = new List<int>();

            LS.Add(58);
            LS.Add(79);
            LS.Add(43);
            LS.Add(90);
            LS.Sort();
            int total = 0;
            foreach (var item in LS)
            {
                listBox1.Items.Add(item);
                total += item;
            }
            listBox1.Items.Add("Total=" + total);
        }
    }


}

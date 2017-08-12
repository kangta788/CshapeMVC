using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Shaps = new Shaps(); 無法建立，因為Shaps是抽象型別 不能new實體化

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Shaps s1 = new Rectangle() { ID = "長方形", Width = 12.0f, Height = 6.0f };
            MessageBox.Show(s1.ShowInfo());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Shaps s2 = new Circle() { ID = "圓形", Radius = 10.0f };
            MessageBox.Show(s2.ShowInfo());

        }
    }
}

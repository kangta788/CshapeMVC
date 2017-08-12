using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp_ch9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Books b1 = new Books();
            MessageBox.Show(b1.getInfo()); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Books b1 = new Books("初學游泳書",350);
            MessageBox.Show(b1.getInfo());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GC.Collect();
        }
    }
}

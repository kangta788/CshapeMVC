using MyCompnay;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Old;

namespace Sample7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Old.Employee obj = new Old.Employee();

            obj.EmployeeID = int.Parse(textBox1.Text);
            obj.FirstName = textBox6.Text.Substring(0, 1).ToUpper() + textBox6.Text.Substring(1).ToLower();
            obj.LastName = textBox8.Text.Substring(0, 1).ToUpper() + textBox8.Text.Substring(1).ToLower();
            obj.HireDate = DateTime.Parse(textBox10.Text);
            if (obj.HireDate > DateTime.Now)
            {
                obj.HireDate = DateTime.Today;
            }
            obj.BirthDate = DateTime.Parse(textBox9.Text);
            if (DateTime.Now.Year - obj.BirthDate.Year < 18)
            {
                obj.BirthDate = new DateTime(1900, 1, 1);
            }
            obj.Salary = int.Parse(textBox7.Text);
            if (obj.Salary < 20008)
            {
                obj.Salary = 20008;
            }

            string result = String.Format("EmployeeID:{0},EmployeeName:{1} {2},HireDate:{3},BirthDate:{4},Salary:{5}", obj.EmployeeID, obj.FirstName, obj.LastName, obj.HireDate, obj.BirthDate, obj.Salary);
            MessageBox.Show(result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employee obj = new Employee();
            //obj.employeeID = int.Parse(textBox2.Text);
            // Error CS0122  'Employee.employeeID' is inaccessible due to its protection level Sample7 C:\temp\Sample7\Sample7\Form1.cs    51

            obj.EmployeeID = int.Parse(textBox2.Text);
            obj.FirstName = textBox3.Text;
            obj.LastName = textBox5.Text;
            //ReadOnly Property
            //obj.HireDate = DateTime.Parse(textBox12.Text);
            obj.BirthDate = DateTime.Parse(textBox11.Text);
            obj.Salary = int.Parse(textBox4.Text);
            string result = String.Format("EmployeeID:{0},EmployeeName:{1} {2},HireDate:{3},Salary:{4}", obj.EmployeeID, obj.FirstName, obj.LastName, obj.HireDate, obj.Salary);
            MessageBox.Show(result);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Employee obj = new Employee();

            obj.SetHireDate(textBox12.Text);
            MessageBox.Show(obj.HireDate.ToString("d"));

            Employee obj2 = new Employee();
            obj2.SetHireDate(new DateTime(2000, 1, 1));
            MessageBox.Show(obj2.HireDate.ToString("d"));

            Employee obj3= new Employee();
            obj3.SetHireDate(2002,12,31);
            MessageBox.Show(obj3.HireDate.ToString("d"));

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Employee obj = new Employee();
            //ReadOnly Property
            //obj.HireDate = DateTime.Parse(textBox12.Text);
            //Error CS0200  Property or indexer 'Employee.HireDate' cannot be assigned to --it is read only Sample7 C:\temp\Sample7\Sample7\Form1.cs    70
            MessageBox.Show(obj.HireDate.ToString("d"));

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Employee obj = new Employee();
            obj.BirthDate= DateTime.Parse(textBox11.Text);
            //MessageBox.Show(obj.BirthDate.ToString("d"));
            //Error CS0154  The property or indexer 'Employee.BirthDate' cannot be used in this context because it lacks the get accessor Sample7 C:\temp\Sample7\Sample7\Form1.cs    100

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Employee obj = new Employee();
            obj.BirthDate = DateTime.Parse(textBox11.Text);

            MessageBox.Show(obj.GetBirthDate());
            MessageBox.Show(obj.GetBirthDate(DateType.ChineseCalendar));
            MessageBox.Show(obj.GetBirthDate(DateType.ChineseLunisolar, DateFormat.LongDate));

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Employee obj = new Employee();
            obj.Phone = "0987-123456";
            MessageBox.Show(obj.Phone);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Employee obj = new Employee();
            //obj.EmployeeID = int.Parse(textBox2.Text);
            //obj.FirstName = textBox3.Text;
            //obj.LastName = textBox5.Text;
            //obj.BirthDate = DateTime.Parse(textBox11.Text);
            //obj.Salary = int.Parse(textBox4.Text);
            Employee obj = new Employee() { EmployeeID = int.Parse(textBox2.Text), FirstName = textBox3.Text, LastName = textBox5.Text, BirthDate = DateTime.Parse(textBox11.Text), Salary = int.Parse(textBox4.Text), Phone="0412312345" };

            string result = String.Format("EmployeeID:{0},EmployeeName:{1} {2},HireDate:{3},Salary:{4}", obj.EmployeeID, obj.FirstName, obj.LastName, obj.HireDate, obj.Salary);
            MessageBox.Show(result);
        }
    }
}

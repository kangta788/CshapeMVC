using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace MyCompnay
{
    namespace newVesion{

        public class Employee
        {

        }
    }
    public partial class Employee
    {
        private int employeeID;
        private String firstName;
        private String lastName;
        private DateTime hireDate;
        private DateTime birthDate;
        private int salary;
       

        public int EmployeeID
        {
            get
            {
                return this.employeeID;
            }

            set
            {
                this.employeeID = value;
            }
        }

        public String FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                this.firstName = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
            }
        }
        public String LastName
        {
            get { return this.lastName; }
            set { this.lastName = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower(); }
        }

        public DateTime HireDate
        {
            //Readonly
            get { return this.hireDate; }
            //set
            //{
            //    //if (value > DateTime.Now)
            //    //{
            //    //    this.hireDate = DateTime.Today;
            //    //}
            //    //else
            //    //{
            //    //    this.hireDate = value;
            //    //}
            //    this.hireDate = value > DateTime.Now ? DateTime.Today : value;
            //}
        }


        public DateTime BirthDate
        {
            //Writeonly
            //get { return this.birthDate; }
            set
            {
                this.birthDate = DateTime.Now.Year - value.Year < 18 ? new DateTime(1900, 1, 1) : value;
            }
        }
        public int Salary
        {
            get { return this.salary; }
            set { this.salary = value < 20008 ? 20008 : value; }
        }


        /*自動實作屬性(編譯器在編譯時會轉換成如下的程式碼)
                  private string phone;
                  public string Phone
                  {
                      get { return this.phone; }
                      set { this.phone = value; }
                  }
              */
        public string Phone { set; get; }
    }


}
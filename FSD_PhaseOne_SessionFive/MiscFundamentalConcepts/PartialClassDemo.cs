//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace MiscFundamentalConcepts
//{
//    public partial class PartialEmployee
//    {
//        private string _firstName;
//        private string _lastName;
//        private double _salary;
//        private string _gender;

//        public string FirstName
//        {
//            get { return _firstName; }
//            set { _firstName = value; }
//        }
//        public string LastName
//        {
//            get { return _lastName; }
//            set { _lastName = value; }
//        }
//        public double Salary
//        {
//            get { return _salary; }
//            set { _salary = value; }
//        }
//        public string Gender
//        {
//            get { return _gender; }
//            set { _gender = value; }
//        }
//    }

//    public partial class PartialEmployee
//    {
        
//        public void DisplayFullName()
//        {
//            Console.WriteLine("Full Name : {0} {1}", _firstName,_lastName);
//        }
//        public void DisplayDetails()
//        {
//            Console.WriteLine("Employee Details : ");
//            Console.WriteLine("First Name: " + _firstName);
//            Console.WriteLine("Last Name: " + _lastName);
//            Console.WriteLine("Salary: " + _salary);
//            Console.WriteLine("Gender: " + _gender);
//        }



//    }

//    class PartialClassDemo
//    {
//        static void Main(string[] args)
//        {
//            PartialEmployee emp = new PartialEmployee();
//            emp.FirstName = "King";
//            emp.LastName = "Kochhar";
//            emp.Salary = 12000.56d;
//            emp.Gender = "Male";
//            emp.DisplayFullName();
//            emp.DisplayDetails();
//            Console.ReadKey();
//        }
//    }
//}

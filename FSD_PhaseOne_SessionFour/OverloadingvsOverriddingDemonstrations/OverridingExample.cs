//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OverloadingvsOverriddingDemonstrations
//{

//    class Person
//    {
//        int id;
//        string name;
//        string city;
//        public Person(): this(101, "Bhawna", "Delhi")
//        {
//            //this.id = 101;
//            //this.name = "Unknown";
//            //this.city = "Delhi";
//        }
//        public Person(int id, string name, string city)
//        {
//            this.id = id;
//            this.name = name;
//            this.city = city;
//        }
//        public void DisplayDetails()
//        {
//            Console.WriteLine("{0} : {1} : {2}", this.id, this.name, this.city);
//        }

//    }

//    class Employee : Person
//    {
//        float baseSalary;

//        public Employee()
//        {
//            this.baseSalary = 20000;
//        }

//        public Employee(int id, string name, string city, float salary) : base(id, name, city)
//        {
//            this.baseSalary = salary;
//        }

//        public new void DisplayDetails()
//        {
//            base.DisplayDetails();
//            Console.WriteLine("{0}", this.baseSalary);
//        }
//    }




//    class OverridingExample
//    {
//        static void Main(string[] args)
//        {
//            Employee employee = new Employee();
//            employee.DisplayDetails();

//            Employee employee1 = new Employee(101, "John" , "Delhi", 20000);
//            employee1.DisplayDetails();

//            Console.ReadKey();
//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ObjectOrientedProgrammingFundamentals
//{
//    class Employee
//    {
//        // Auto Implemented Properties
//        public int EmpId { get; set; }
//        public string EmpName  { get; set; }
//        public int EmpAge { get; }
//        public int EmpSalary { get; set; }
//    }

//    class Student
//    {
//        private int _studentId;
//        private string _studentName;
//        private int _studentAge;

//        public Student()
//        {
//            this._studentName = "Unknown";
//        }

//        // Read-Write Property
//        public int StudentId
//        {
//            get
//            {
//                return _studentId;
//            }
//            set
//            {
//                if (value < 0)
//                    // throw new Exception("Id value should be greater than Zero.");
//                    Console.WriteLine("Id value should be greater than Zero.");
//                else
//                    _studentId = value;
                
                
//            }
//        }

//        // Read Property
//        public string StudentName
//        {
//            get
//            {
//                return _studentName;
//            }
//        }

//        // Write Property
//        public int StudentAge
//        {
//            set
//            {
//                _studentAge = value;
//            }
//        }
//        public void displayDetails()
//        {
//            Console.WriteLine("Student Information :");
//            Console.WriteLine("Student Id : " + this._studentId);
//            Console.WriteLine("Student Name : " + this._studentName);
//            Console.WriteLine("Student Age : " + this._studentAge);
            
//        }
//    }


//    class PropertiesDemo
//    {
//        static void Main(string[] args)
//        {
//            Student student = new Student();
//            //student._studentId = 101;
//            Console.WriteLine(" Student Id : " + student.StudentId);
//            Console.WriteLine(" Student Name : " + student.StudentName);
//            //Console.WriteLine(" Student Age : " + student.StudentAge);
//            student.StudentId = -1001;
//            // student.StudentName = "Bhawna";
//            student.StudentAge = 23;
//            Console.WriteLine(" Student Id : " + student.StudentId);
//            Console.WriteLine(" Student Name : " + student.StudentName);

//            student.displayDetails();

//            Console.ReadKey();
//        }
//    }
//}

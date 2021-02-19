//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ObjectOrientedProgrammingFundamentals
//{

//    class Student
//    {
//        // Data Members (Attributes/Instance Variables)
//        int StudentId;
//        string StudentName;
//        int StudentAge;

//        // Static Data Members (Non Instance Variables)
//        static string company;

//        // Default Constructor(Non-Parameterized Constructor)
//        public Student()
//        {
//            this.StudentId = 1001;
//            this.StudentName = "Unknown";
//            this.StudentAge = 18;
//        }

//        // Parameterized Constructor
//        public Student(int StudentId, string StudentName, int StudentAge)
//        {
//            this.StudentId = StudentId;
//            this.StudentName = StudentName;
//            this.StudentAge = StudentAge;
//        }

//        // Static Constructor
//        static Student()
//        {
//            Student.company = "Simlilearn";
//            //company = "Simplilearn";
//        }

//        //Copy Constructor
//        //public Student(Student stud)
//        //{
//        //    this.StudentId = stud.StudentId;
//        //    this.StudentName = stud.StudentName;
//        //    this.StudentAge = stud.StudentAge;
//        //}

//        public object Clone()
//        {
//            return this.MemberwiseClone();
//        }

//        // Member Functions (Methods/Instance Methods)
//        public void displayDetails()
//        {
//            Console.WriteLine("Student Information :");
//            Console.WriteLine("Student Id : " + this.StudentId);
//            Console.WriteLine("Student Name : " + this.StudentName);
//            Console.WriteLine("Student Age : " + this.StudentAge);
//            Console.WriteLine("Company Name : " + Student.company);
//        }
//    }

//    class ConstructorDemo
//    {
//        static void Main(string[] args)
//        {
//            Student student1 = new Student();
//            student1.displayDetails();

//            Student student2 = new Student(1002, "King Kochhar", 34);
//            student2.displayDetails();

//            //Student student3 = new Student(student2);
//            //student3.displayDetails();

//            Student student4 = student2.Clone() as Student;
//            student4.displayDetails();

//            Console.ReadKey();
//        }
//    }
//}

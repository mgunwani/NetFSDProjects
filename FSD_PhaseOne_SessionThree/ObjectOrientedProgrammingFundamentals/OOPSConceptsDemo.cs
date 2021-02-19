
//using System;

//namespace ObjectOrientedProgrammingFundamentals
//{

//    class Student
//    {
//        Data Members(Attributes/Instance Variables)
//        int StudentId;
//        string StudentName;
//        int StudentAge;

//        Static Data Members(Non Instance Variables)
//        static string company = "Simplilearn";

//        Member Functions(Methods/Instance Methods)
//        public void acceptDetails()
//        {
//            Console.Write("Enter Student Name : ");
//            this.StudentName = Console.ReadLine();
//            Console.Write("Enter Student Id : ");
//            this.StudentId = int.Parse(Console.ReadLine());
//            Console.Write("Enter Student Age : ");
//            this.StudentAge = int.Parse(Console.ReadLine());
//        }
//        public void displayDetails()
//        {
//            Console.WriteLine("Id : " + StudentId + " , Name : " + StudentName + " , Age : " + StudentAge);
//            Console.WriteLine("Id : {0}, Name : {1}, Age : {2}", this.StudentId, this.StudentName, this.StudentAge);
//            Console.WriteLine("Student Information :");
//            Console.WriteLine("Student Id : " + this.StudentId);
//            Console.WriteLine("Student Name : " + this.StudentName);
//            Console.WriteLine("Student Age : " + this.StudentAge);
//            Console.WriteLine("Company Name : " + Student.company);
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {


//            Student student1 = new Student();
//            student1.acceptDetails();
//            student1.displayDetails();

//            Student student2 = new Student();
//            student2.acceptDetails();
//            student2.displayDetails();

//            Student student3 = new Student();
//            student3.acceptDetails();
//            student3.displayDetails();

//            Console.ReadKey();
//        }
//    }
//}

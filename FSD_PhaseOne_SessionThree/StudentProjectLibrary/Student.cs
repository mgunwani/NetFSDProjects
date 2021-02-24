using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProjectLibrary
{
    public class Student
    {
        // Instance Data Members
        int StudentId;
        string StudentName;
        int StudentAge;
        // Static Data Members
        public static string companyName;

        static Student()
        {
            Student.companyName = "Simplilearn";
        }

        public static void welcomeMessage()
        {
            Console.WriteLine("Thanks for using Student Management LMS!!");
        }

        public void acceptDetails()
        {
            Console.Write("Enter Student Name : ");
            this.StudentName = Console.ReadLine();
            Console.Write("Enter Student Id : ");
            this.StudentId = int.Parse(Console.ReadLine());
            Console.Write("Enter Student Age : ");
            this.StudentAge = int.Parse(Console.ReadLine());
        }
        public void displayDetails()
        {
            Console.WriteLine("Student Information :");
            Console.WriteLine("Student Id : " + this.StudentId);
            Console.WriteLine("Student Name : " + this.StudentName);
            Console.WriteLine("Student Age : " + this.StudentAge);
            Console.WriteLine("University Name : " + Student.companyName);

        }
    }

}

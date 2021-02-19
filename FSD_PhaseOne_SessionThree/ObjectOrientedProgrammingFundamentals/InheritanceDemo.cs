using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingFundamentals
{

    class Student
    { 
        int StudentId;
        string StudentName;
        int StudentAge;
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
 
        }
    }


    class Marks : Student
    {
        float ObjectiveMarks;
        float SubjectiveMarks;

        public new void acceptDetails()
        {
            base.acceptDetails();
            Console.Write("Enter Objective Marks : ");
            this.ObjectiveMarks = float.Parse(Console.ReadLine());
            Console.Write("Enter Subjective Marks : ");
            this.SubjectiveMarks = float.Parse(Console.ReadLine());
        }
        public new void displayDetails()
        {
            base.displayDetails();
            Console.WriteLine("Marks Information :");
            Console.WriteLine("Objective Marks : " + this.ObjectiveMarks);
            Console.WriteLine("Subjective Marks : " + this.SubjectiveMarks);
        }
    }

    class Sports : Marks
    {
        float score;
        public new void acceptDetails()
        {
            base.acceptDetails();
            Console.Write("Enter Sports Score : ");
            this.score = float.Parse(Console.ReadLine());
        }
        public new void displayDetails()
        {
            base.displayDetails();
            Console.WriteLine("Sports Score : " + this.score);
        }

    }

    class InheritanceDemo
    {
        static void Main(string[] args)
        {
            Sports obj = new Sports();

            obj.acceptDetails();
            obj.displayDetails();

            Console.ReadKey();

        }
    }
}

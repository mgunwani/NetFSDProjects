using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProjectLibrary
{
    public class Marks : Student
    {
        protected float ObjectiveMarks;
        protected float SubjectiveMarks;

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

}

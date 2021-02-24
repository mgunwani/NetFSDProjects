using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProjectLibrary
{
    public class Result : Sports
    {
        double totalMarks;
        double averageMarks;

        public void calculateResult()
        {
            this.totalMarks = this.ObjectiveMarks + this.SubjectiveMarks + this.score;
            this.averageMarks = this.totalMarks / 3;
            Console.WriteLine("Total Marks : " + this.totalMarks);
            Console.WriteLine("Average Marks : " + this.averageMarks);
        }
    }
}

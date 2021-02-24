using StudentProjectLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingFundamentals
{
    class InheritanceDemo
    {
        static void Main(string[] args)
        {
            Result obj = new Result();

            obj.acceptDetails();
            obj.displayDetails();
            obj.calculateResult();

            //Console.WriteLine(Student.companyName);
            Student.welcomeMessage();

            Console.ReadKey();


        }
    }
}

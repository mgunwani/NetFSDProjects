using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProjectLibrary
{
    public class Sports : Marks
    {
        protected float score;
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
}

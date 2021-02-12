using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundamentals
{
    class TypeCastingExample
    {
        static void Main(string[] args)
        {
            /***
             * TypeCasting: To Convert one data variable into another one.
             */

            /*
            int num = 100;
            Console.WriteLine("Number = " + num);
            double result = num * 0.4F;     // Implicit(Widening) Type Casting
            Console.WriteLine("Result = " + result);
            Console.ReadKey();
            */

            /*
            int num = 100;
            Console.WriteLine("Number = " + num);
            int result = (int)(num * 0.4F);     // Explicit(Narrowing) Type Casting
            Console.WriteLine("Result = " + result);
            Console.ReadKey();
            */

            /* byte, short and char gets converted to int before implementing any calculations. */
            byte num1 = 100;
            byte num2 = 200;
            byte num3 = (byte)(num1 + num2);        // Explicit Type Casting
            int num4 = num1 + num2;                 // Implcit Type Casting
            Console.WriteLine("Number One : " + num1);
            Console.WriteLine("Number Two : " + num2);
            Console.WriteLine("Number Three : " + num3);
            Console.WriteLine("Number Four : " + num4);
            Console.ReadKey();

            
        }
    }
}

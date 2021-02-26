using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscFundamentalConcepts
{
    // Function Pointer
    public delegate void MathDelegate(int n1,int n2);
    class DelegateDemo
    {
        public static void Add(int num1, int num2) 
        {
            Console.WriteLine("Addition : " + (num1 + num2));
        }
        public static void Subtract(int num1, int num2)
        {
            Console.WriteLine("Subtraction : " + (num1 - num2));
        }
        public static void Multiply(int num1, int num2)
        {
            Console.WriteLine("Multiplication : " + (num1 * num2));
        }
        public static void Divide(int num1, int num2)
        {
            Console.WriteLine("Division : " + (num1 / num2));
        }
       
        static void Main(string[] args)
        {
            MathDelegate del1 = new MathDelegate(Add);
            MathDelegate del2 = new MathDelegate(Subtract);
            MathDelegate del3 = new MathDelegate(Multiply);
            MathDelegate del4 = new MathDelegate(Divide);

            //del1(100, 200);
            //del1 = new MathDelegate(Subtract);
            //del1(100, 200);

            MathDelegate del5 = del1 + del2 + del3 + del4;
            del5.Invoke(200, 300);
            Console.WriteLine();
            del5 -= del2;
            del5.Invoke(200, 300);
            Console.ReadKey();
        }


        
    }

}

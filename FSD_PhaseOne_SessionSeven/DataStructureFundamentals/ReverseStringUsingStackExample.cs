using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureFundamentals
{
    class ReverseStringUsingStackExample
    {
        public static string Reverse(string input)
        {
            Stack<Char> stack = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
                stack.Push(input[i]);

            string reversed = "";
            
            while (!(stack.Count() == 0))
                reversed += stack.Pop();


            return reversed;
        }

        public static void Main(string[] args)
        {
            string str = "ABCD";
            Console.WriteLine("Original String : " + str);
            Console.WriteLine("Reversed String : " + Reverse(str));
            Console.ReadKey();
        }
    }
}

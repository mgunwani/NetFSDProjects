//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataStructureFundamentals
//{
//    class BigONotation
//    {
//        /*
//        public void log(int[] numbers)
//        {
//            // O(1) - Constant Time
//            //Console.WriteLine(numbers[0]);
//            // O(1) - Constant Time
//            //Console.WriteLine(numbers[0]);

//            // O(1) + O(1)
//            // O(2)
//            // O(1) - Constant Time
//            Console.WriteLine(numbers[0]);
//            Console.WriteLine(numbers[0]);
//        }
//        */

//        /*
//        public void log(int[] numbers)
//        {
//            // O(1) + O(n) + O(1)
//            // O(n) + O(2)
//            // O(n)
//            //Console.WriteLine();                            // O(1)
//            //for (int i = 0; i < numbers.Length; i++)        // O(n)
//            //    Console.WriteLine(numbers[i]);
//            //Console.WriteLine();                            // O(1)


//            // O(n) + O(n)
//            // O(n + n) => O(2n)
//            // O(n)
//            for (int i = 0; i < numbers.Length; i++)        // O(n)
//                Console.WriteLine(numbers[i]);
//            foreach (var number in numbers)                 // O(n)
//                Console.WriteLine(number);
//        }
//        */

//        /*
//        public void log(int[] numbers, string[] names)
//        {
//            // O(n) + O(m)
//            // O(n + m)
//            // O(n)
//            foreach (var number in numbers)     // O(n)
//                Console.WriteLine(number);

//            foreach (var name in names)         // O(m)
//                Console.WriteLine(name);
//        }
//        */

//    public void log(int[] numbers)
//    {
//        // O(n) * O(n)
//        // O(n^2)   - Quadratic Time
//        foreach (var first in numbers)  // O(n)
//        {
//            foreach (var second in numbers) // O(n)
//            {
//                Console.WriteLine(first + " : " + second);
//            }
//        }

//        // O(n) + O(n^2)
//        // O( n + n ^ 2)
//        // O(n^2)   // Quadratic Time
            
//        // O(n)
//        foreach (var number in numbers)     // O(n)
//            Console.WriteLine(number);
//        // O(n^2)
//        foreach (var first in numbers)      // O(n)
//            foreach (var second in numbers) // O(n)
//                Console.WriteLine(first + " : " + second);
//           }
//    }

    

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            BigONotation bigONotation = new BigONotation();
//            int[] nums = { 1, 2, 3, 4, 5 };
//            string[] names = { "King", "Kochhar", "John" };
//            bigONotation.log(nums);
//            //bigONotation.log(nums, names);
//            Console.ReadKey();
//        }
//    }
//}

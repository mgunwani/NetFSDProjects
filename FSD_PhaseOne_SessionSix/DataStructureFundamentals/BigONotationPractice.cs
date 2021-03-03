//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataStructureFundamentals
//{
//    class Notations
//    {
//        // O(1) - Constant Time
//        // Because, input array can be 1 item or more item 
//        // and we are accessing only very first item from array.
//        public void printFirstElementofArray(int[] numbers)
//        {
//            Console.WriteLine(numbers[0]);
//        }

//        // O(n) - Linear Time
//        // Because, input array can be 1 item or 1000 item
//        // Thus, n is not fixed or constant
//        public void printAllElementsOfArray(int[] numbers)
//        {
//            foreach (int number in numbers)
//            {
//                Console.WriteLine(number);
//            }
//        }

//        // O(n^2) - Quadratic Time 
//        // Where, If the array has 10 items, but array is not fixed/constant
//        // we have to print 100 items or depends upon array size.
//        public void printAllPossibleOrderedPairs(int[] numbers, int size)
//        {
//            for (int i = 0; i < size; i++)
//            {
//                for (int j = 0; j < size; j++)
//                {
//                    Console.WriteLine(numbers[i] + " : " + numbers[j]);
//                }
//            }
//        }

//        // O(2^n) - Exponential Time
//        // Here, it is recursive calculation.
//        // In this notation, the growth doubles with each addition to input.
//        public int fibonacci(int num)
//        {
//            if (num <= 1) return num;
//            return fibonacci(num - 2) + fibonacci(num - 1);
//        }

//        // O(2n) => O(n) - Linear Time
//        // Here, all items are printed twice using for loop
//        public void printAllItemsTwice(int[] numbers, int size)
//        {
//            for (int i = 0; i < size; i++)
//            {
//                Console.WriteLine(numbers[i]);
//            }
//            for (int i = 0; i < size; i++)
//            {
//                Console.WriteLine(numbers[i]);
//            }
//        }

//        // O(1) + O(n/2) + O(100)
//        // O(n) + O(101)
//        // O(n) - Linear Time
//        public void printFirstItemThenFirstHalfThenSayHi100Times(int[] numbers, int size)
//        {
//           Console.WriteLine(numbers[0]);
//            for (int i = 0; i < size / 2; i++)
//            {
//                Console.WriteLine(numbers[i]);
//            }
//            for (int i = 0; i < 100; i++)
//            {
//                Console.WriteLine("Hi");
//            }
//        }

//    }
//    class BigONotationPractice
//    {
//        static void Main(string[] args)
//        {
//            Notations notation = new Notations();
//            int[] numbers = { 1, 2, 3, 4, 5 };

//            notation.printFirstElementofArray(numbers);
//            Console.WriteLine("------------------");
//            notation.printAllElementsOfArray(numbers);
//            Console.WriteLine("------------------");
//            notation.printAllPossibleOrderedPairs(numbers, numbers.Length);
//            Console.WriteLine("------------------");
//            Console.WriteLine(notation.fibonacci(5));
//            Console.WriteLine("------------------");
//            notation.printAllItemsTwice(numbers, numbers.Length);
//            Console.WriteLine("------------------");
//            notation.printFirstItemThenFirstHalfThenSayHi100Times(numbers, numbers.Length);
//            Console.ReadKey();
//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataStructureFundamentals
//{
//    class WorkingWithSingleDimentionalArraysExample
//    {
//        public static void Main(string[] args)
//        {
//            // Initializing the Array
//            int[] numbers = { 31, 12, 30, 14, 5 };
//            string[] names = { "King", "Kochhar", "Sarah", "Bowling" };
//            var evenNumbers = new int[5] { 2, 4, 6, 8, 10 };
//            var oddNumbers = new int[] { 1, 3, 5, 7 };

//            // Declare and Initialize:
//            int[] nums = new int[10];
//            nums[0] = 10;
//            nums[1] = 20;
//            // Throws run-time exception IndexOutOfRange
//            // nums[10] = 100;

//            // Access Index Elements:
//            foreach (var number in oddNumbers)
//                Console.WriteLine(number);

//            Console.WriteLine("-------------------------");

//            // LINQ Methods:
//            Console.WriteLine(numbers.Min());
//            Console.WriteLine(numbers.Max());
//            Console.WriteLine(numbers.Sum());
//            Console.WriteLine(numbers.Average());

//            Console.WriteLine("-------------------------");

//            // Array Methods:
//            Array.Sort(numbers);
//            Array.Reverse(numbers);
//            Array.ForEach(numbers, num => Console.WriteLine(num));


//            Console.ReadLine();

//        }
//    }
//}

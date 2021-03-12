//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataStructureSeachingAlgorithms
//{
//    class LinearSearch
//    {
//        // Best Case : O(1)
//        // Worst Case: O(n)
//        // Average Case: O(n/2) => O(n)

//        public static int search(int[] array, int target)
//        {
//            for (int i = 0; i < array.Length; i++)
//            {
//                if(array[i] == target)
//                {
//                    return i;
//                }
//            }
//            return -1;
//        }
//    }
//    class LinearSearchDemo
//    {
//        static void Main(string[] args)
//        {
//            int[] numbers = { 5, 10, 45, 3, 20 };
//            var index = LinearSearch.search(numbers, 20);
//            Console.WriteLine("Element Found at Index : " + index);
//            Console.ReadKey();
//        }
//    }
//}

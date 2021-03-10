//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataStructureSeachingAlgorithms
//{
//    class BinarySearch
//    {
//        public static int binarySearchIterative(int[] array, int target)
//        {
//            var left = 0;
//            var right = array.Length - 1;

//            while (left <= right)
//            {
//                var middle = (left + right) / 2;

//                if (array[middle] == target)
//                    return middle;

//                if (target < array[middle])
//                    right = middle - 1;

//                if (target > array[middle])
//                    left = middle + 1;
//            }

//            return -1;
//        }
//        public static int binarySearchRecursive(int[] array, int target, int left, int right)
//        {
//            if (right < left)
//                return -1;

//            int middle = (left + right) / 2;

//            if (array[middle] == target)
//                return middle;

//            if (target < array[middle]) 
//                return binarySearchRecursive(array, target, left, middle - 1);

//            return binarySearchRecursive(array, target, middle + 1, right);
//        }
//    }
//    class BinarySearchDemo
//    {
//        static void Main(string[] args)
//        {
//            int[] numbers = { 2, 5, 8, 12, 16, 23, 38, 56 };
//            var index = BinarySearch.binarySearchRecursive(numbers, 102, 0, numbers.Length - 1);
//            Console.WriteLine("Element Found at Index : " + index);
//            Console.ReadKey();

//            //int[] numbers = { 2, 5, 8, 12, 16, 23, 38, 56 };
//            //var index = BinarySearch.binarySearchIterative(numbers, 18);
//            //Console.WriteLine("Element Found at Index : " + index);
//            //Console.ReadKey();

//        }
//    }
//}

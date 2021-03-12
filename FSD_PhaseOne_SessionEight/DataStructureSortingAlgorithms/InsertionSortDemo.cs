//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataStructureSortingAlgorithms
//{
//    class InsertionSort
//    {
//        public int[] sort(int[] array)
//        {
//            for (int i = 1; i < array.Length; i++)
//            {
//                var current = array[i];
//                var j = i - 1;
//                while (j >= 0 && array[j] > current)
//                {
//                    array[j + 1] = array[j];
//                    j--;
//                }
//                array[j + 1] = current;
//            }
//            return array;
//        }
//    }
//    class InsertionSortDemo
//    {
//        public static void Main(string[] args)
//        {
//            int[] numbers = { 7, 3, 5, 2, 3 };
//            var sorter = new InsertionSort();
//            Array.ForEach(sorter.sort(numbers), n => Console.WriteLine(n));
//            Console.ReadKey();
//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataStructureSortingAlgorithms
//{
//     class BubbleSort
//    {
//        public int[] sort(int[] array)
//        {
//            for (int i = 0; i < array.Length; i++)
//            {
//                for (int j = 1; j < array.Length-i; j++)
//                {
//                    if (array[j] < array[j-1])
//                    {
//                        swap(array, j, j - 1);
//                    }
//                }
//            }
//            return array;
//        }
//        private void swap(int[] array, int index1, int index2)
//        {
//            var temp = array[index1];
//            array[index1] = array[index2];
//            array[index2] = temp;
//        }
//    }
//    class BubbleSortDemo
//    {
//        static void Main(string[] args)
//        {
//            int[] numbers = { 7, 3, 1, 4, 6, 2, 3 };
//            BubbleSort sorter = new BubbleSort();
//            Array.ForEach(sorter.sort(numbers), n => Console.WriteLine(n)); 
//            Console.ReadKey();
//        }
//    }
//}

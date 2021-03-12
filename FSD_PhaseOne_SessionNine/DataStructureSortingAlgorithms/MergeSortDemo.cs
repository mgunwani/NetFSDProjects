//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataStructureSortingAlgorithms
//{
//    class MergeSort
//    {
//        public int[] sort(int[] array)
//        {
//            if (array.Length < 2)
//                return array;

//            // Divide this array into Half
//            var middle = array.Length / 2;

//            int[] left = new int[middle];

//            for (int i = 0; i < middle; i++)
//                left[i] = array[i];

//            int[] right = new int[array.Length - middle];

//            for (int i = middle; i < array.Length; i++)
//                right[i - middle] = array[i];

//            // Sort Each Half
//            sort(left);
//            sort(right);

//            // Merge the result
//            return merge(left, right, array);

//        }

//        public int[] merge(int[] left, int[] right, int[] result)
//        {
//            int i = 0, j = 0, k = 0;
//            while(i<left.Length && j < right.Length)
//            {
//                if (left[i] <= right[j])
//                    result[k++] = left[i++];
//                else
//                    result[k++] = right[j++];
//            }
//            while (i < left.Length)
//                result[k++] = left[i++];

//            while (j < right.Length)
//                result[k++] = right[j++];

//            return result;
//        }
//    }
//    class MergeSortDemo
//    {
//        public static void Main(string[] args)
//        {
//            int[] numbers = { 7, 3, 5, 2, 3, 1, 5, 8 };
//            var sorter = new MergeSort();
//            Array.ForEach(sorter.sort(numbers), n => Console.WriteLine(n));
//            Console.ReadKey();
//        }
//    }
//}

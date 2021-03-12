using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureSeachingAlgorithms
{
    class ExponentialSearch
    {
        public static int binarySearchRecursive(int[] array, int target, int left, int right)
        {
            if (right < left)
                return -1;

            int middle = (left + right) / 2;

            if (array[middle] == target)
                return middle;

            if (target < array[middle])
                return binarySearchRecursive(array, target, left, middle - 1);

            return binarySearchRecursive(array, target, middle + 1, right);
        }
        public static int search(int[] array, int target)
        {
            int bound = 1;
            while (bound < array.Length && array[bound] < target)
                bound = bound * 2;

            int left = bound / 2;
            int right = Math.Min(bound, array.Length - 1);
            return binarySearchRecursive(array, target, left, right);
            
        }
    }

    class ExponentialSearchDemo
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, 6, 8, 11, 34, 40 };
            int index = ExponentialSearch.search(numbers, 30);
            Console.WriteLine("Element found at index : " + index);
            Console.ReadKey();
        }
    }
}

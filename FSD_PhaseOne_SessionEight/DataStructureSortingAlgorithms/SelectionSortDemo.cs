using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureSortingAlgorithms
{
    class SelectionSort
    {
        public int[] sort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                var minIndex = i;
                for (int j = i; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                        minIndex = j;
                }
                swap(array, minIndex, i);
            }
            return array;
        }
        private void swap(int[] array, int index1, int index2)
        {
            var temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }
    }
    class SelectionSortDemo
    {
        static void Main(string[] args)
        {
            int[] numbers = { 7, 3, 1, 4, 6, 2, 3 };
            SelectionSort sorter = new SelectionSort();
            Array.ForEach(sorter.sort(numbers), n => Console.WriteLine(n));
            Console.ReadKey();
        }
    }
}

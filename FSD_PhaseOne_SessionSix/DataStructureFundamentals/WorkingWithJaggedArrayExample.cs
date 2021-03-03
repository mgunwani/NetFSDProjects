using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureFundamentals
{
    class WorkingWithJaggedArrayExample
    {
        public static void Main(string[] args)
        {
            // Declaring Two Single Dimensions Array:
            int[][] array = new int[2][];
            array[0] = new int[] { 10, 20, 30 };
            array[1] = new int[] { 10, 20, 30, 40, 50 };

            int[][] array1 = new int[2][]
            {
                new int[6]{1,2,3,4,5,6 },
                new int[5]{1,2,3,4,5 }
            };

            int[][,] array2 = new int[2][,]
            {
                new int[2,3] {{1,2,3 },{4,5,6 } },
                new int[3,4]{ { 1,2,3,4}, {1,2,3,4 }, {1,2,3,4 } }
            };

            Console.WriteLine(array2[0][1, 1]);
            Console.ReadKey();
        }
    }
}

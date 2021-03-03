//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataStructureFundamentals
//{
//    class WorkingWithMultiDimentionalArrayExample
//    {
//        public static void Main(string[] args)
//        {
//            /**
//             * Multi-Dimensional Arrays stores data upto 32 Dimensions.
//             * Where, the dimension is row and second is column.
//             */
            
//            // Initializing Multi-Dimension Array
//            int[,] array = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
//            var array1 = new int[2,3] { { 1, 2, 3 }, { 4, 5, 6 } };

//            int rows = 2, columns = 3;
//            // Declaring Multi-Dimensional Array
//            int[,] array3 = new int[rows, columns];
//            array3[0, 0] = 1;
//            array3[0, 1] = 2;
//            array3[0, 2] = 3;
//            array3[1, 0] = 4;
//            array3[1, 1] = 5;
//            array3[1, 2] = 6;

//            for (int i = 0; i < rows; i++)
//            {
//                for (int j = 0; j < columns; j++)
//                {
//                    Console.Write(array[i,j] + "\t");
//                }
//                Console.WriteLine();
//            }
//            Console.ReadKey();

//        }
//    }
//}

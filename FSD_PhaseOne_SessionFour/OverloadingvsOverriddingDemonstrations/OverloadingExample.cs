//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OverloadingvsOverriddingDemonstrations
//{
//    class Calculate
//    {
//        public int addition(int num1, int num2)
//        {
//            return num1 + num2;
//        }

//        public double addition(double num1, double num2)
//        {
//            return num1 + num2;
//        }

//        public int addition(int[] numbers)
//        {
//            int result = 0;
//            for (int i = 0; i < numbers.Length; i++)
//                result += numbers[i];
//            return result;
//        }

//        public double addition(double[] numbers)
//        {
//            double result = 0;
//            for (int i = 0; i < numbers.Length; i++)
//                result += numbers[i];
//            return result;
//        }
//    }


//    class Program
//    {
//        static void Main(string[] args)
//        {

//            Calculate calculate = new Calculate();
           
//            Console.WriteLine(calculate.addition(100, 200));

//            Console.WriteLine(calculate.addition(45.67d, 200.56d));

//            int[] intArray = { 10, 20, 30, 40, 50 };
//            Console.WriteLine(calculate.addition(intArray));

//            double[] doubleArray = { 10.5d, 20.2d, 30.5d, 40.6d, 50.6d };
//            Console.WriteLine(calculate.addition(doubleArray));

//            Console.ReadKey();

//        }
//    }
//}

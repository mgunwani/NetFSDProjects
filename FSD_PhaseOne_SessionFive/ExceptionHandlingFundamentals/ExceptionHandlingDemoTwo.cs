//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ExceptionHandlingFundamentals
//{
//    class ExceptionHandlingDemoTwo
//    {
//        static void Main(string[] args)
//        {
//            int num1 = 10, num2 = 0;
//            int result = 0;
//            try
//            {
//                result = num1 / num2;
//            }
//            catch(Exception ex)
//            {
//                Console.WriteLine("Exception Occurred..");
//                //Console.WriteLine(ex);
//                Console.WriteLine(ex.Message);
//                Console.WriteLine(ex.Source);
//            }
//            Console.WriteLine("Number One : {0} and Number Two: {1}", num1, num2);
//            Console.WriteLine("Result : " + result);
//            Console.ReadKey();
//        }
//    }
//}

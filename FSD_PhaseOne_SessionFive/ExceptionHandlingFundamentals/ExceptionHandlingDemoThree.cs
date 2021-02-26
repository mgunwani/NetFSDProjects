//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ExceptionHandlingFundamentals
//{
//    class ExceptionHandlingDemoThree
//    {
//        static void Main(string[] args)
//        {
//            int num1, num2;
//            int result = 0;
//            try
//            {
//                Console.Write("Enter Number One : ");
//                num1 = int.Parse(Console.ReadLine());
//                Console.Write("Enter Number Two : ");
//                num2 = int.Parse(Console.ReadLine());
//                result = num1 / num2;
//                Console.WriteLine("Number One : {0} and Number Two: {1}", num1, num2);
//                Console.WriteLine("Result : " + result);
//            }
//            catch(DivideByZeroException ex)
//            {
//                Console.WriteLine("Exception Occurred..");
//                //Console.WriteLine(ex);
//                Console.WriteLine(ex.Message);
//                Console.WriteLine(ex.Source);
//            }
//            catch (IndexOutOfRangeException ex)
//            {
//                Console.WriteLine("Exception Occurred..");
//                //Console.WriteLine(ex);
//                Console.WriteLine(ex.Message);
//                Console.WriteLine(ex.Source);
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Exception Occurred..");
//                //Console.WriteLine(ex);
//                Console.WriteLine(ex.Message);
//                Console.WriteLine(ex.Source);
//            }
//            Console.ReadKey();
//        }
//    }
//}

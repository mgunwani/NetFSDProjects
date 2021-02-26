//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ExceptionHandlingFundamentals
//{
//    /*
//    class InvalidAgeException: Exception
//    {
//        public override string Message
//        {
//            get
//            {
//                return "Age is not valid to vote.";
//            }
//        }
//    }*/

//    class InvalidAgeException : Exception
//    {
//        public InvalidAgeException() : base("Age is not valid to vote..")
//        {
//        }
//        public InvalidAgeException(string message): base(message) 
//        { 
//        }
//    }

//    class ExceptionHandlingDemoFour
//    {
//        static void checkAge()
//        {
//            int age;
//            Console.Write("Enter Number One : ");
//            age = int.Parse(Console.ReadLine());
//            if (age < 18)
//            {
//                throw new InvalidAgeException("Age is not valid");
//                //throw new InvalidAgeException();
//            }
//            else
//            {
//                Console.WriteLine("User is valid to vote");
//            }

//            Console.ReadKey();
//        }

//        static void Main(string[] args)
//        {
//           try
//            {
//                checkAge();
//            }
//            catch(InvalidAgeException ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//            Console.ReadKey();
//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp_Fundamentals
//{
//    class TakingDifferentInputsExample
//    {
//        static void Main(string[] args)
//        {

//            int EmployeeCode;
//            string EmployeeName;
//            float EmployeeSalary;
//            double EmployeeContact;
//            bool isFresher;

//            Console.Write("Enter Name : ");
//            EmployeeName = Console.ReadLine();
//            Console.Write("Enter Code : ");
//            //EmployeeCode = Convert.ToInt32(Console.ReadLine());
//            EmployeeCode = int.Parse(Console.ReadLine());
//            Console.Write("Enter Salary : ");
//            // EmployeeSalary = Convert.ToSingle(Console.ReadLine());
//            EmployeeSalary = float.Parse(Console.ReadLine());
//            Console.Write("Enter Contact Number : ");
//            // EmployeeContact = Convert.ToDouble(Console.ReadLine());
//            EmployeeContact = double.Parse(Console.ReadLine());
//            Console.Write("Are you Freasher : ");
//            //isFresher = Convert.ToBoolean(Console.ReadLine());
//            isFresher = bool.Parse(Console.ReadLine());

//            Console.WriteLine("Employee Code : " + EmployeeCode);
//            Console.WriteLine("Employee Name : " + EmployeeName);
//            Console.WriteLine("Employee Salary : " + EmployeeSalary);
//            Console.WriteLine("Employee Contact No : " + EmployeeContact);
//            Console.WriteLine("Are you Fresher : " + isFresher);
//            Console.ReadKey();
//        }

//    }
//}

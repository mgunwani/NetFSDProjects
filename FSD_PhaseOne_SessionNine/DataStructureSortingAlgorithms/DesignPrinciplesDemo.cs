//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataStructureSortingAlgorithms
//{

//    public class Employee
//    {
//        public int ID { get; set; }
//        public string Name { get; set; }
//        public string Department { get; set; }
//        public int Salary { get; set; }
//    }

//    // High-Level Module
//    class EmployeeBusinessLogic
//    {
//        EmployeeDataAccess employeeDataAccess;
//        public EmployeeBusinessLogic()
//        {
//            employeeDataAccess = DataAccessFactory.GetEmployeeDataAccessObject();
//        }
//        public Employee GetEmployeeDetails(int id)
//        {
//            return employeeDataAccess.GetEmployeeDetails(id);
//        }
//    }

//    class DataAccessFactory
//    {
//        public static EmployeeDataAccess GetEmployeeDataAccessObject()
//        {
//            return new EmployeeDataAccess();
//        }
//    }
    
//    // Low-Level Module
//    class EmployeeDataAccess
//    {
//        public Employee GetEmployeeDetails(int id)
//        {
//            Employee emp = new Employee()
//            {
//                ID = id,
//                Name = "King Kochhar",
//                Department = "Testing",
//                Salary = 20000
//            };
//            return emp;
//        }
//    }

//    class DesignPrinciplesDemo
//    {
//        public static void Main(string[] args)
//        {
//            EmployeeBusinessLogic obj = new EmployeeBusinessLogic();
//            var emp = obj.GetEmployeeDetails(101);
//            Console.WriteLine("{0} : {1} : {2} : {3}", emp.ID, emp.Name, emp.Department, emp.Salary);
//            Console.ReadKey();
//        }
//    }
//}

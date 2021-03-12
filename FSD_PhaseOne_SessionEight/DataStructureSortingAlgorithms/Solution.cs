using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureSortingAlgorithms
{

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }
    }

    public interface IEmployeeDataAccess
    {
        Employee GetEmployeeDetails(int id);
    }

    public class EmployeeDataAccess : IEmployeeDataAccess
    {
        public Employee GetEmployeeDetails(int id)
        {
            Employee emp = new Employee()
            {
                ID = id,
                Name = "King Kochhar",
                Department = "Testing",
                Salary = 20000
            };
            return emp;
        }
    }
    public class DataAccessFactory
    {
        public static IEmployeeDataAccess GetEmployeeDataAccessObject()
        {
            return new EmployeeDataAccess();
        }
    }
    public class EmployeeBusinessLogic
    {
        IEmployeeDataAccess employeeDataAccess;
        public EmployeeBusinessLogic()
        {
            employeeDataAccess = DataAccessFactory.GetEmployeeDataAccessObject();
        }
        public Employee GetEmployeeDetails(int id)
        {
            return employeeDataAccess.GetEmployeeDetails(id);
        }
    }
    class Solution
    {
    }
}

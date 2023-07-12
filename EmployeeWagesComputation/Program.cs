using System;

namespace EmployeeWagesComputation
{
    class Program
    {
        public static void Main(string[] args)
        {
            EmployeeWages employeeWages = new EmployeeWages();
            employeeWages.EmployeeAttendence();
            employeeWages.CalculateExpWage();
        }
    }
}

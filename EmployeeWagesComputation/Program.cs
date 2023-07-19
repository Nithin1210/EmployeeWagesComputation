using System;

namespace EmployeeWagesComputation
{
    class Program
    {
        public static void Main(string[] args)
        {
            EmployeeWages employeeWages = new EmployeeWages("AutoMobile",10,20,30);
            employeeWages.EmployeeAttendence();
            employeeWages.CalculateExpWage();
        }
    }
}

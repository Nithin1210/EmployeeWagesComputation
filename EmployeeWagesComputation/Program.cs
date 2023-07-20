using System;

namespace EmployeeWagesComputation
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Employee wage computation");
            bool flag = true;

            EmployeeWages IphoneWage = new EmployeeWages("Iphone", 3000, 2, 10);
            IphoneWage.CalculateExpWage();
            EmployeeWages Android = new EmployeeWages("Android", 2800, 8, 20);
            Android.CalculateExpWage();
            
        }
    }
}

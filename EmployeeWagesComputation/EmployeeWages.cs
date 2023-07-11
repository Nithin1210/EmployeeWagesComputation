using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWagesComputation
{
    internal class EmployeeWages
    {
        const int wage_per_hr = 20, full_day_hr = 8;
        public  void EmployeeAttendence()
        {
            
            Random random = new Random();
            int expCheck = random.Next(0, 2);
            if (expCheck == 0)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Absent");
        }
        public void CalculateExpWage()
        {
            int dailyExpWage = wage_per_hr * full_day_hr;
            Console.WriteLine(dailyExpWage);
        }
    }
}

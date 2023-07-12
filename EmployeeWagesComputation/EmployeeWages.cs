using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWagesComputation
{
    internal class EmployeeWages
    {
        const int wage_per_hr = 20, full_day_hr = 8, part_day_hr = 4,
            is_full_time = 8, is_part_time = 1 , total_working_day=20;
        int totalExpWage = 0, emphrs = 0;
        Random random = new Random();
        public   void EmployeeAttendence()
        {
            int empCheck = random.Next(0, 2);
            if (empCheck == 0)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Absent");
        }
        public void CalculateExpWage()
        {
            for (int i = 0; i < total_working_day; i++)
            {

            
                int empCheck=random.Next(0, 3);
                switch (empCheck)
                {
                    case is_full_time:
                        emphrs += full_day_hr;
                        break;
                    case is_part_time:
                        emphrs += part_day_hr;
                        break;
                    default:
                        emphrs += 0;
                        break;
                }

            }
           
            
            int totalEmpWage = wage_per_hr * emphrs;
            Console.WriteLine(totalEmpWage);
        }
    }
}

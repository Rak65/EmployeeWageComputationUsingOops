using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationUsingOops
{
    public class CheckEmp
    {
        public void DailyEmpWage()
        {
            int IS_FULL_TIME = 1;
            int dayHour = 0;
            int dailyEmpWage = 0;
            int WAGE_PER_HOUR = 20;
            Random random = new Random();
            int empCheck = random.Next(2);
            if (empCheck == IS_FULL_TIME)
            {
                dayHour = 8;
            }
            else
            {
                dayHour = 0;
            }
            dailyEmpWage = dayHour * WAGE_PER_HOUR;
            Console.WriteLine("Daily Employee wage = " + dailyEmpWage);
        }
    }
}

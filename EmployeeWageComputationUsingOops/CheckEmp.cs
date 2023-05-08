using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationUsingOops
{
    public class CheckEmp
    {
        public void PartFullEmpWage()
        {
            //Constant
            int IS_FULL_TIME = 1;
            int IS_PART_TIME = 2;
            int WAGE_PER_HOUR = 20;
            //Variables
            int dayHour = 0;
            int dailyEmpWage = 0;
            Random random = new Random();
            //computation
            int empCheck = random.Next(3);
            if (empCheck == IS_FULL_TIME)
            {
                dayHour = 8;
            }
            else if (empCheck == IS_PART_TIME)
            {
                dayHour = 4;
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

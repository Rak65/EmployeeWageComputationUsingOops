using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationUsingOops
{
    public class CheckEmp
    {
        //constant
        const int IS_FUL_TIME = 1;
        const int IS_PART_TIME = 2;
        const int NO_OF_WORKING_DAYS = 20;        //20 working days per month
        const int EMP_RATE_PER_HOUR = 20;
        const int MAX_WORKING_HOUR = 100;
        public void MonthEmpWage()
        {
            //variable
            int dayHour = 0;
            int totalHours = 0;
            int totalWorkingDays = 0;
            //computation
            while (totalHours < MAX_WORKING_HOUR && totalWorkingDays < NO_OF_WORKING_DAYS)
            {
                Random random = new Random();
                int empCheck = random.Next(3);
                switch (empCheck)
                {
                    case IS_FUL_TIME:
                        dayHour = 8;
                        break;
                    case IS_PART_TIME:
                        dayHour = 4;
                        break;
                    default:
                        dayHour = 0;
                        break;

                }
                totalHours += dayHour;
                totalWorkingDays++;
                Console.WriteLine("Day# " + totalWorkingDays + " Employee hours = " + dayHour);
            }
            int totalEmpWage = totalHours * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total Employee wage = " + totalEmpWage);

        }
    }
}
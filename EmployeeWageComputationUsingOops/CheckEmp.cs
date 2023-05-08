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
        const int IS_FUL_TIME = 1;
        const int IS_PART_TIME = 2;
        public int ComputeEmpWage(string company, int EMP_RATE_PER_HOUR, int NO_OF_WORKING_DAYS, int MAX_WORKING_HOUR)
        {
            int dayHour = 0;
            int totalHours = 0;
            int totalWorkingDays = 0;
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
            return totalEmpWage;
        }
    }
}
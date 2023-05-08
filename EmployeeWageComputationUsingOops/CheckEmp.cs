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
        //Constant
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int WAGE_PER_HOUR = 20;
        public void PartFullEmpWage()
        {
            //Variables
            int dayHour = 0;
            int dailyEmpWage = 0;
            Random random = new Random();
            //computation
            int empCheck = random.Next(3);
            switch (empCheck)
            {
                case IS_FULL_TIME :
                    dayHour = 8;
                    break;
                case IS_PART_TIME :
                    dayHour = 4;
                    break;
                default :
                    dayHour = 0;
                    break;

            }
            dailyEmpWage = dayHour * WAGE_PER_HOUR;
            Console.WriteLine("Daily Employee wage = " + dailyEmpWage);
        }
    }
}
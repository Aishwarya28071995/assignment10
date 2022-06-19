using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_HOURS_IN_MONTH = 100;

        public static void computeEmpWage(String company, int empRatePerHr, int numberOfWorkingDays, int maxHoursPerMonth)
        {
            int empHrs = 0;
            int totalWorkingDays = 0;
            int totalEmpHours = 0;
            int totalEmpWage = 0;
            while (totalEmpHours <= MAX_HOURS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;

                }
                totalEmpHours += empHrs;

                totalEmpWage = totalEmpHours * EMP_RATE_PER_HOUR;
            }
            Console.WriteLine("total employee wage is of company"+company+"is " + totalEmpWage);
        }
    }
    }


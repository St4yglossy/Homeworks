using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollApp
{
    class Employee
    {
        //Properties
        public double HourlyRate { get; set; }
        public double HoursWorked { get; set; }
        public string Name { get; set; }
        public double BasePay { get; set; }
        public double TotalPay { get; set; }

        //constuctor
        //Need to set the hourly rate to $20.75
        public Employee(double hourlyRate)
        {
            HourlyRate = 20.75;
            
        }


        //methods
        //Calculates pay based on hours worked and hourly rate
        public static void CaluclateEmployeePay()
        {
            Console.WriteLine($"Your current pay is {hourlyRate} * {HoursWorked}");
        }

    }
}

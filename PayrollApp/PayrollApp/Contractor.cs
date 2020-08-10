using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollApp
{
    class Contractor
    {
        //Properties
        public double HourlyRate { get; set; }
        public double Hoursworked { get; set; }
        public string Name { get; set; }
        public double BasePay { get; set; }

        public double TotalPay { get; set; }

        public double OverTimeRate { get; set; }
        public double OverTimeHours { get; set; }

        public Contractor()
        {
            HourlyRate = 30;
        }

        public double CalulateContractorPay()
        {
            BasePay = HourlyRate * Hoursworked;
           TotalPay = BasePay + (OverTimeRate * OverTimeHours);
            return TotalPay; 
        }

    }
}

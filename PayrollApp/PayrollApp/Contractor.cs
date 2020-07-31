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
        public double OverTimeRate { get; set; }
        public double OverTimeHours { get; set; }

        public Contractor()
        {

        }

        public static void CalulateContractorPay()
        { 
        
        }

    }
}

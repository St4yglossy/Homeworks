﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollApp
{
    class Manager
    {
        //Properties
        public double HourlyRate { get; set; }
        public double HoursWorked { get; set; }
        public string Name { get; set; }
        public double BasePay { get; set; }
        public double TotalPay { get; set; }
        public double Allowances { get; set; }

        public Manager()
        {
            HourlyRate = 50;
            Allowances = 100;
        }

        public double CalulateManagerPay()
        {

            BasePay = HourlyRate * HoursWorked;
            return BasePay;

        }
    }
}

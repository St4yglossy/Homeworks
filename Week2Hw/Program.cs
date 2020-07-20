using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Hw
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask for temperature
            Console.WriteLine("Please enter a Temperature in Fahrenheit");
            int temp = Convert.ToInt16(Console.ReadLine());
            int sum = (temp - 32) * 5 / 9;
            Console.WriteLine("The temperature in Celsius is " + sum + " degrees");
            Console.ReadLine();

            //Convert from feet to meters
            Console.WriteLine("Please enter a length in Feet");
            int length = Convert.ToInt16(Console.ReadLine());
            double sum2 = length / 3.281;
            string l = sum2.ToString("N2");
            Console.WriteLine("Your length in Meters is " + l);
            Console.ReadLine();

            //Volumne in gallons
            Console.WriteLine("Please enter a number in gallons");
            int gallons = Convert.ToInt16(Console.ReadLine());
            double sum3 = gallons * 3.785;
            string g = sum3.ToString("N2");
            Console.WriteLine("Your gallons in Liters is " + g);
            Console.ReadLine();

            //Weight converted to Kilograms
            Console.WriteLine("Please enter a weight in pounds");
            int pounds = Convert.ToInt16(Console.ReadLine());
            double sum4 = pounds / 2.205;
            string p = sum4.ToString("N2");
            Console.WriteLine("Your weight in Kilograms is " + p);
            Console.ReadLine();

            //Challenge - Formatting money
            Console.WriteLine("Please enter in a price");
            double money = Convert.ToDouble(Console.ReadLine());
            string m = money.ToString("N2");
            Console.WriteLine("The price you enter is $" + m);
            Console.ReadLine();

        }
    }
}

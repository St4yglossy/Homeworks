using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //make a switch statment to determine if user is a manager, employee or contractor 

            Console.WriteLine("Welcome to the Payroll Application");
            Console.WriteLine("Please select (1)for manager, (2) for employee and (3) for contractor");

            int role = Convert.ToInt16(Console.ReadLine());
            int view = Convert.ToInt16(Console.ReadLine());
            switch (role)
            {
                case 1: //for manager 
                    Console.WriteLine("To View list of employess press 1. To add employees and their hours press 2. To exit press 3");
                    switch (view)
                    {
                        case 1:
                        //employee list
                        case 2:
                        //Manager list
                        case 3:
                            //Contract list

                            break;
                            
                        
                    }
                    break;
                case 2: //for employee
                    Console.WriteLine("Please enter your First name ");
                    string fname = Console.ReadLine();
                    Console.WriteLine(fname);
                    Console.WriteLine("Number of Hours worked");
                    int hours = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine(hours);
                    break;
                case 3: //for contractor 
                    break;
                default:
                    Console.WriteLine("You can only select (1)for manager, (2) for employee and (3) for contractor. Please Try Again!");
                    break;
            }
        }
    }
}

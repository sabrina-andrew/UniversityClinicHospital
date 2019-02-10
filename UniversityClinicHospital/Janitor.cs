using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Janitor : Employee
    {
        public bool sweep { get; set; }

        public Janitor()
        {
        }

        public void AddJanitor()
        {
            
        }

        public void JanitorSweeping()
        {
            bool sweep = true;
            if (sweep == true)
            {
                sweep = false;
                Console.WriteLine("The janitor is sweeping");
            }
            else
            {
                sweep = true;
                Console.WriteLine("The janitor is on his break");
            }
        }

        public void JanitorGetsPaid()
        {
            Console.WriteLine("Here is $40,000.");
        }

        public override void EmployeeStatus()
        {
            base.EmployeeStatus();

            Console.WriteLine("Employee Name:  " + Name);
            Console.WriteLine("Employee ID Number:  " + EmployeeNumber);
            Console.WriteLine("Salary:  " + Salary);
            Console.WriteLine("Paid:  " + GotPaid);
        }
    }
}

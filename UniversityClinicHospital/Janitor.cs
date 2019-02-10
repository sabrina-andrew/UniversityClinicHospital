using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Janitor : Employee
    {
        public bool Sweep { get; set; }
        public string Type { get; set; }
        public bool Paid { get; set; }



        public Janitor()
        {
            Name = "Fred";
            EmployeeNumber = 123;
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

            bool Paid = true;
            if (Paid == true)
            {
                Paid = false;
                Console.WriteLine("The janitor got paid $40,000.");
            }
            else
            {
                Paid = true;
                Console.WriteLine("The janitor already got paid.");
            }
        }

        public override void EmployeeStatus()
        {
            Console.WriteLine("Employee Name:  " + Name);
            Console.WriteLine("Employee ID Number:  " + EmployeeNumber);
            Console.WriteLine("Salary:  " + Salary);
            Console.WriteLine("Paid:  " + GotPaid);
        }
    }
}

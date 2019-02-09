using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Janitor : Employee
    {
        public string JanitorSalary = ("40,000");

        public Janitor()
        {
        }

        public void AddJanitor()
        {
            Console.WriteLine("What is your janitors name?");
            Name = Console.ReadLine();
        }

        public void JanitorGetsPaid()
        {
            Console.WriteLine("Here is $40,000.");
        }
    }
}

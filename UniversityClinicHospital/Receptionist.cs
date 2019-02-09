using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Receptionist : Employee
    {
        public string ReceptionistSalary = ("45,000");

        public Receptionist()
        {
        }

        public void AddReceptionist()
        {
            Console.WriteLine("What is the receptionist name?");
            Name = Console.ReadLine();
        }

        public void GetsPaid()
        {
            Console.WriteLine("Here is $45,000.");
        }
    }
}

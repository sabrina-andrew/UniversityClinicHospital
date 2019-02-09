using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Nurse : Employee
    {

        public string NurseSalary = ("50,000");

        public Nurse()
        {
        }

        public void AddNurse()
        {
            Console.WriteLine("What is your nurses name?");
            Name = Console.ReadLine();
        }

        public void NurseGetsPaid()
        {
            Console.WriteLine("Here is $50,000.");
        }

    }
}

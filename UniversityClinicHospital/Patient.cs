using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Patient : Employee
    {
        public int Blood_Level { get; set; }
        public int Health_Level { get; set; }

        public Patient()
        {
            Blood_Level = 20;
            Health_Level = 10;
        }

        public void AddPatient()
        {
            Console.WriteLine("What is the patients name?");
            Name = Console.ReadLine();
        }              
    }
}

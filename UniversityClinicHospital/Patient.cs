using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Patient 
    {   public string Name { get; set; }
        public int Blood_Level { get; set; }
        public int Health_Level { get; set; }
        public string Age { get; set; }

        public Patient()
        {
            Blood_Level = 20;
            Health_Level = 10;
        }

        public void AddPatient()
        {
            Console.WriteLine("Patient has been admitted"); 
        }              

        public void RingForDoctor()
        {
            Console.WriteLine("Doctor drew the patients blood.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Patient
    {
        public string Name { get; set; }
        public int Blood_Level { get; set; }
        public int Health_Level { get; set; }
        public string Age { get; set; }

        public Patient()
        {
            Blood_Level = 20;
            Health_Level = 10;
            Name = "Steve Urkel";
            Age = "34";
        }

        public void AddPatient()
        {
        }

        public void DrDrewBlood()
        {
            if (Blood_Level <= 10)
            {
                Health_Level += 10;
            }
        }
        public void NurseDrewBlood()
        {
            if (Blood_Level <= 10)
            {
                Health_Level += 15;
            }
        }

        public void PatientGoesHome()
        {
            if (Health_Level == 100)
                Console.WriteLine("The patient gets to go home!");
        }
        public void Status()
        {
            Console.WriteLine("Patient Name:  " + Name);
            Console.WriteLine("Age:  " + Age);
            Console.WriteLine("Blood Level:  " + Blood_Level);
            Console.WriteLine("Health level:  " + Health_Level);
        }
    }
}


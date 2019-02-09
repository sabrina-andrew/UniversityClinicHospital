using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Doctor : Employee
    {

        public string specialty;        
        public string DoctorSalary = ("90,000");

        public  Doctor()
        {
        }
        
        public void AddDoctor()
        {
            Console.WriteLine("What is your doctors name?");
            Name = Console.ReadLine();
            Console.WriteLine("What is the doctors specialty?");
            specialty = Console.ReadLine();
            Console.WriteLine("What is the employee ID number?");
            EmployeeNumber = Console.ReadLine();
        }

        public void GetsPaid()
        {
            Console.WriteLine("Here is $90,000.");
        }
    }
}

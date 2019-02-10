using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Receptionist : Employee
    {
        public bool ReceptionistOnPhone { get; set; }

        public Receptionist()
        {
        }

        public void AddReceptionist()
        {
        }

        public void OnPhone()
        {
            if (ReceptionistOnPhone == true)
            {
                ReceptionistOnPhone = true;
                Console.WriteLine("The receptionist can help you");
            }
            else
            {
                ReceptionistOnPhone = false;
                Console.WriteLine("The receptionist is talking to her boyfriend");

            }
        }

        public void GetsPaid()
        {

            bool Paid = true;
            if (Paid == true)
            {
                Paid = false;
                Console.WriteLine("The receptionist got paid $45,000.");
            }
            else
            {
                Paid = true;
                Console.WriteLine("The receptionist already got paid.");
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

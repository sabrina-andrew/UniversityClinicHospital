﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Receptionist : Employee
    {
        public bool ReceptionistOnPhone { get; set; }

        public Receptionist()
        {
            Name = "Roxi";
            EmployeeNumber = 12;
            Salary = 45000;
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

        public override void PayEmployees()
        {

            bool Paid = true;
            if (Paid == true)
            {
                Paid = false;
                Console.WriteLine("\nThe receptionist got paid $45,000.");
            }
            else
            {
                Paid = true;
                Console.WriteLine("\nThe receptionist already got paid.");
            }
        }

        public override void EmployeeStatus()
        {
            Console.WriteLine("\n\nEmployee Name:  " + Name);
            Console.WriteLine("Employee ID Number:  " + EmployeeNumber);
            Console.WriteLine("Salary:  " + Salary);
            Console.WriteLine("Paid:  " + GotPaid);
            Console.WriteLine("What is the receptionist doing:  " + ReceptionistOnPhone);

        }
    }
}

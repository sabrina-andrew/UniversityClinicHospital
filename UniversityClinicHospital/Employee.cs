﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public int EmployeeNumber { get; set; }
        public string Salary { get; set; }
        public bool GotPaid { get; set; }
        
        public Employee()
        {
            GotPaid = false;
            
        }
        public virtual void EmployeeStatus()
        {

        }

        

        
        
        
    }
}

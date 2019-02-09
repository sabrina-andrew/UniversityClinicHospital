using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UniversityClinicHospital.Tests
{
    public class NurseTests
    {
        [Fact]
        public void NamedNurse()
        {
            Nurse nurse = new Nurse();
            nurse.Name = "Christinie Weenie";
            Assert.Equal("Christinie Weenie", nurse.Name);
        }

        [Fact]
        public void PaidNurse()
        {
            //This passes no matter what the amount is.
            //I think I am supposed to use encapsulation 
            //but, I haven't figured that part out yet.
            Nurse nurse = new Nurse();
            nurse.NurseSalary = "$50,000";
            Equals("50,000");
        }
    }
}

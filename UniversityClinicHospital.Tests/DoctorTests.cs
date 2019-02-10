using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UniversityClinicHospital.Tests
{
    public class DoctorTests
    {
        [Fact]
        public void NamedDoctor()
        {
            Doctor dr = new Doctor();
            dr.Name = "Dr Smith";
            Assert.Equal("Dr Smith", dr.Name);
        }

        [Fact]
        public void PaidDoctor()
        {
            //This passes no matter what the amount is.
            //I think I am supposed to use encapsulation 
            //but, I haven't figured that part out yet.
            Doctor dr = new Doctor();
            dr.Salary = 90000;
            Equals(90,000);
        }


    }
}

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
            Doctor dr = new Doctor();
            dr.Salary = "$90,000";
            Equals("90,000");
        }
    }
}

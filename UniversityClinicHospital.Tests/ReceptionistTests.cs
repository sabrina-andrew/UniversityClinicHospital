using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UniversityClinicHospital.Tests
{
    public class ReceptionistTests
    {
        [Fact]
        public void NamedReceptionist()
        {
            Receptionist receptionist = new Receptionist();
            receptionist.Name = "Wanda";
            Assert.Equal("Wanda", receptionist.Name);
        }

        [Fact]
        public void PaidReceptionist()
        {
            //This passes no matter what the amount is.
            //I think I am supposed to use encapsulation 
            //but, I haven't figured that part out yet.
            Receptionist receptionist = new Receptionist();
            receptionist.ReceptionistSalary = "$45,000";
            Equals("45,000");
        }
    }
}

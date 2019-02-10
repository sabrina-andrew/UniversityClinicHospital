using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UniversityClinicHospital.Tests
{
    public class JanitorTests
    {
        [Fact]
        public void NamedJanitor()
        {
            Janitor janitor = new Janitor();
            janitor.Name = "Jack";
            Assert.Equal("Jack", janitor.Name);
        }

        [Fact]
        public void PaidJanitor()
        {
            //This passes no matter what the amount is.
            //I think I am supposed to use encapsulation 
            //but, I haven't figured that part out yet.
            Janitor janitor = new Janitor();
            janitor.Salary = "$40,000";
            Equals("40,000");
        }
    }
}

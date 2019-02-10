using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UniversityClinicHospital.Tests
{
    public class PatientTests
    {
        public void NamedPatient()
        {
            Patient patient = new Patient();
            patient.Name = "Officer Dangle";
            Assert.Equal("Officer", patient.Name);
        }

        public void HealthStartsAtTen()
        {
            Patient patient = new Patient();

            Assert.Equal(10, patient.Health_Level);
        }

        public void DrDrewBlood()
        {
            Patient patient = new Patient();
            Assert.Equal(10, patient.Health_Level);
            
        }
    }
}

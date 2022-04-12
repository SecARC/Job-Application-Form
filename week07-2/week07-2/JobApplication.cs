using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week07_2
{
    public class JobApplication
    {
        public string jobTitles { get; set; }
        public string fullName { get; set; }
        public DateTime birthDate { get; set; }
        public string birthPlace { get; set; }

        public bool drivingLicenseA { get; set; }
        public bool drivingLicenseB { get; set; }
        public bool drivingLicenseE { get; set; }
        public bool drivingLicenseH { get; set; }
        public bool isDrivingLicenseNotExist
        {
            get { return !drivingLicenseA && !drivingLicenseB && !drivingLicenseE && !drivingLicenseH; }
        }

        public string educationLevel { get; set; }
        public string educationGraduationFrom { get; set; }
        public double educationGPA { get; set; }

        public string interests { get; set; }
    }
}

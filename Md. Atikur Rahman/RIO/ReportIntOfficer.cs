using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIO
{
    public class ReportIntOfficer
    {
        public string Name { get; set; }
        public string Designation { get; set; }

        public string DepartmentName { get; set; }
        public string DOB { get; set; }

        public string email { get; set; }

        public string mobile { get; set; }

        public string PeriodOfLastYear { get; set; }

        public string LastYearActivities { get; set; }

        public DbSet<ReportIntOfficer> reportIntOfficers { get; set; }
    }
}

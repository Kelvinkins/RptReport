using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RptReportApp
{
    class DataModel
    {
        public string EnrolleeNumber { get; set; }
        public string Company { get; set; }
        public string Hospital { get; set; }
        public string LastName { get; set; }
        public string OtherName { get; set; }
        public string Plan { get; set; }
        public decimal FeeForService { get; set; }
        public decimal Capitation { get; set; }
        public decimal PremiumPerIndividual { get; set; }
        public int CommissionPerIndividualPercentage { get; set; }
        public DateTime Date { get; set; }

    }
}

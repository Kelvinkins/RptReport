using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RptReportApp
{
    public class DataModel
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
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string State { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public DateTime? SystemDateTime { get; set; }


    }
}

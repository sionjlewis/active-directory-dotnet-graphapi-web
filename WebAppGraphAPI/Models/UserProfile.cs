using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppGraphAPI.Models
{
    public class UserProfile
    {
        public string DisplayName { get; set; }
        public string GivenName { get; set; }
        public string Surname { get; set; }

        // Plus some other properties...
        public string JobTitle { get; set; }
        public string Department { get; set; }
        public string PhysicalDeliveryOfficeName { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Mobile { get; set; }
        public string TelephoneNumber { get; set; }
        public string FacsimileTelephoneNumber { get; set; }
        public string Mail { get; set; }
        public string EmployeeId { get; set; }
        public string PreferredLanguage { get; set; }
    }
}
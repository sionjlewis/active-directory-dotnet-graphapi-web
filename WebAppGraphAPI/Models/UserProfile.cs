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
        /// <summary>
        /// Email Address.
        /// </summary>
        public string Mail { get; set; }
        public string EmployeeId { get; set; }
        public string PreferredLanguage { get; set; }
        /// <summary>
        /// User Principal Name (UPN) is the name of a system user in an e-mail address format.
        /// </summary>
        public string userPrincipalName { get; set; }
        /// <summary>
        /// Attribute is separate from Country and is used while assigning a license to a user in Office 365.
        /// </summary>
        public string usageLocation { get; set; }
        /// <summary>
        /// The SIP address is used by Communications Server or Lync Server to route incoming calls and send voice mail to the user.
        /// </summary>
        public string sipProxyAddress { get; set; }
    }
}

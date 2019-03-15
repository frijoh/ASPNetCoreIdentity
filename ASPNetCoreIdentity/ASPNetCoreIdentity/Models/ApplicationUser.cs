using Microsoft.AspNetCore.Identity;

namespace ASPNetCoreIdentity.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        
        public string Address { get; set; }

        public string PostalCode { get; set; }
        
        public string City { get; set; }
        
        public string PersonalIdNumber { get; set; }

    }
}

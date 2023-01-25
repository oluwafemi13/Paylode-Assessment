using Microsoft.AspNetCore.Identity;

namespace Weather_API.Data
{
    public class User:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}

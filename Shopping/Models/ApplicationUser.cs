using Microsoft.AspNetCore.Identity;

namespace Shopping.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string Name { get; set; }
    }
}

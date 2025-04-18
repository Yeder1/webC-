using Microsoft.AspNetCore.Identity;

namespace Buoi6EF.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Fullname { get; set; }
        public string? Address { get; set; }

        public int Age { get; set; }
    }
}

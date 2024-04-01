using Microsoft.AspNetCore.Identity;

namespace jwtagain.Models.Domain
{
    public class ApplicationUser:IdentityUser
    {
        public string? Name { get; set; }
    }
}

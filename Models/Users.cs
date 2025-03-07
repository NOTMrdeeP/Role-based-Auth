using Microsoft.AspNetCore.Identity;

namespace Role_based_Auth.Models
{
    public class Users : IdentityUser
    {
        public string FullName { get; set; } = string.Empty;
    }
}

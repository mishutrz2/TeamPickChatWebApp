using Microsoft.AspNetCore.Identity;
using TeamPickChatWebApp.Data.Enums;

namespace TeamPickChatWebApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? Nickname { get; set; }
        public UserType? UserType { get; set; }
    }
}

using Microsoft.AspNetCore.Identity;

namespace _2180603819_TranLeNgocHuy_lab03.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
    }
}

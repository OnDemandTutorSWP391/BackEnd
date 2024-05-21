using Microsoft.AspNetCore.Identity;

namespace OnDemandTutorApi.DataAccessLayer.Entity
{
    public class User : IdentityUser
    {
        public string? FullName { get; set; } = null!;
        public string? IdentityCard { get; set; } = null!;
        public DateTime Dob { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Status { get; set; }
        public string Gender { get; set; } = null!;
    }
}

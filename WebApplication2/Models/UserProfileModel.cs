using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Models
{
    public class UserProfileModel : UsersModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        public string Birthday { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string ProfilePhoto { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace Task_Identity_Role_Claim_User.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<CustomClaim> UserClaim { get; set; }
        public string Email { get; set; }
    }
}

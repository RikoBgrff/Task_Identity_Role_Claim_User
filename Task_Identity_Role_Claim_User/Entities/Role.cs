using System.Collections.Generic;
using System.Security.Claims;

namespace Task_Identity_Role_Claim_User.Entities
{
    public class Role
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
        public List<RoleClaim> RoleClaims { get; set; }
    }
}
using System.Collections.Generic;
using System.Security.Claims;

namespace Task_Identity_Role_Claim_User.Entities
{
    public class RoleClaim
    {
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public int ClaimId { get; set; }
        public CustomClaim Claim { get; set; }
    }
}

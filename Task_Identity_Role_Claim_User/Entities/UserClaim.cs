using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace Task_Identity_Role_Claim_User.Entities
{
    public class UserClaim
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int ClaimId { get; set; }
        public CustomClaim Claim { get; set; }

    }
}

using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Task_Identity_Role_Claim_User.Entities;

namespace Task_Identity_Role_Claim_User.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserClaim> UserClaims { get; set; }
        public DbSet<RoleClaim> RoleClaims { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RoleClaim>().HasKey(rc => new { rc.RoleId, rc.ClaimId });
            modelBuilder.Entity<UserClaim>().HasKey(rc => new { rc.UserId, rc.ClaimId });
        }
    }
}


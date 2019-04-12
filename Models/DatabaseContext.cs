using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace QazATK.Models
{
    public class DatabaseContext : IdentityDbContext
    {
        private DbSet<User> users;

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
: base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityUser>().ToTable("Users");
            builder.Entity<IdentityRole>().ToTable("Roles");
            builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins");
            builder.Entity<IdentityRoleClaim<string>>().ToTable("UserRoleClaims");
            builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims");
            builder.Entity<IdentityUserToken<string>>().ToTable("UserTokens");
            builder.Entity<IdentityUserRole<string>>().ToTable("UserRoles");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Nationality> Nationalities { get; set; }
        public DbSet<Enrollee> Enrollee { get; set; }
        public DbSet<EducationLevel> EducationLevels { get; set; }
        public DbSet<InstructionLanguage> InstructionLanguages { get; set; }
        public DbSet<PreviousEducation> PreviousEducations { get; set; }
        public DbSet<InternationalCertificate> InternationalCertificates { get; set; }
    }
}
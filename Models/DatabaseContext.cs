using System;
using Microsoft.EntityFrameworkCore;

namespace QazATK.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) 
            :base(options) {}

            //public DbSet<User> Users { get; set; }        
            public DbSet<Nationality> Nationalities { get; set; }
            public DbSet<Enrollee> Enrollee { get; set; }
            public DbSet<EducationLevel> EducationLevels { get; set; }
            public DbSet<InstructionLanguage> InstructionLanguages { get; set; }
            public DbSet<PreviousEducation> PreviousEducations { get; set; }
    }
}
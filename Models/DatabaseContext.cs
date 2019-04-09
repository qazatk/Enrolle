using System;
using Microsoft.EntityFrameworkCore;

namespace QazATK.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) 
            :base(options) {}

            internal DbSet<User> Users { get; set; }        
    }
}
using demoweb.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace demoweb.Data
{
    public class MyAppDbContext : DbContext
    {
        public MyAppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
    }
}

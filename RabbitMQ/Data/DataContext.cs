using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using UserAPI.Models;

namespace UserAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
    }
}

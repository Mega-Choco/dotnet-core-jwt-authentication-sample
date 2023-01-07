using jwt_authentication_sample.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace jwt_authentication_sample.Services
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DatabaseContext(DbContextOptions options) : base(options) { }
    }
}

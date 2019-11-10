using Account.Service.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Account.Service.Persistence
{
    public class AccountDbContext : DbContext
    {
        public AccountDbContext(DbContextOptions<AccountDbContext> options)
           : base(options)
        {          

        }

        public DbSet<Domain.Entities.User> User { get; set; }

        public DbSet<Domain.Entities.Account> Account { get; set; }
    }
}

using efTest.Entity;
using Microsoft.EntityFrameworkCore;

namespace efTest.Data;


    public class UserDataContext : DbContext
    {
    public UserDataContext(DbContextOptions<UserDataContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
}
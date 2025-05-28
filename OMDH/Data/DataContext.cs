using Microsoft.EntityFrameworkCore;
using OMDH.Models;

namespace OMDH.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<EmailUserName> NewsLetterSubscriptions { get; set; }
    }
}
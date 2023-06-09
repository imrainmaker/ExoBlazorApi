using Blazor.DAL.Entities;
using Microsoft.EntityFrameworkCore;


namespace Blazor.DAL.Context
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Game> Games { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=GOS-VDI1202\TFTIC;"
        //                                + "Database=BlazorDB;"
        //                                + "Trusted_Connection=True;"
        //                                + "TrustServerCertificate=True;");
        //}
    }
}

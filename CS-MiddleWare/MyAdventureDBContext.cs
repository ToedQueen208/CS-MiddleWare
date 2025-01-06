using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace CS_MiddleWare
{
    public class MyAdventureDBContext : DbContext
    {
        public DbSet<Adventurer> adventurers { get; set; }
        //public const string CONNECTION_STRING = "Server=localhost\\SQLEXPRESS01;Database=AdventureDatabase;User Id=JaylaC;Password=Password;Trust Server Certificate=True";

        public MyAdventureDBContext(DbContextOptions<MyAdventureDBContext> options): base(options)
        {

        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(CONNECTION_STRING);
        //}
    }
}

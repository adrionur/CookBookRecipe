using CookBookRecipe.Entities;
using Microsoft.EntityFrameworkCore;

namespace CookBookRecipe.DB
{
    public class SQLiteContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=sqlitedemo.db");
    }
}
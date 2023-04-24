using LearningWebDatabase.Models;
using Microsoft.EntityFrameworkCore;

namespace LearningWebDatabase.Data
{
    public class MyDbContext : DbContext
    {

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        { }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Carro> Carros { get; set; }

    }
}

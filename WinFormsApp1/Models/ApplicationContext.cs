using System.Configuration;
using Microsoft.EntityFrameworkCore;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }//таблица клиентов
        public DbSet<Zone> Zones { get; set; }//таблица зон

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //берём строку подключения из app.config
            string connectionString = ConfigurationManager.ConnectionStrings["TestConnection"].ConnectionString;
            optionsBuilder.UseNpgsql(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //настройка через fluent api
            modelBuilder.Entity<Client>()
                .Property(c => c.ContactInfo)
                .IsRequired()//обязательное поле
                .HasMaxLength(255);

            modelBuilder.Entity<Client>()
                .Property(c => c.Discount)
                .HasPrecision(5, 2);//точность как в бд

            modelBuilder.Entity<Zone>()
                .Property(z => z.Name)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
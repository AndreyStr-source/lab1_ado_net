using Microsoft.EntityFrameworkCore;
using Lab2EF_CodeFirst.Models;

namespace Lab2EF_CodeFirst
{
    public class AquaParkContext : DbContext
    {
        public DbSet<Zone> Zones { get; set; }//таблица зон
        public DbSet<Visit> Visits { get; set; }//таблица посещений

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //строка подключения к новой бд
            optionsBuilder.UseNpgsql("Host=localhost;Port=5433;Database=AquaParkDB;Username=postgres;Password=1234;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //настройка связи 1-*
            modelBuilder.Entity<Visit>()
                .HasOne(v => v.Zone)
                .WithMany(z => z.Visits)
                .HasForeignKey(v => v.ZoneId);

            //инициализация данных (требование п.3 методички)
            modelBuilder.Entity<Zone>().HasData(
                new Zone { Id = 1, Name = "Горки", Cost = 500 },
                new Zone { Id = 2, Name = "Бассейн", Cost = 300 },
                new Zone { Id = 3, Name = "Сауна", Cost = 700 }
            );

            modelBuilder.Entity<Visit>().HasData(
    new Visit { Id = 1, VisitDate = new System.DateTime(2026, 4, 24, 0, 0, 0, System.DateTimeKind.Utc), Hours = 2, ZoneId = 1 },
    new Visit { Id = 2, VisitDate = new System.DateTime(2026, 4, 25, 0, 0, 0, System.DateTimeKind.Utc), Hours = 3, ZoneId = 2 }
);
        }
    }
}
using Microsoft.EntityFrameworkCore;
using MyApi.Domain.Entities;

namespace MyApi.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Employee> Employees => Set<Employee>();
        public DbSet<User> Users => Set<User>();
        public DbSet<Call> Calls => Set<Call>();
        public DbSet<LevelOne> LevelOnes => Set<LevelOne>();
        public DbSet<LevelTwo> LevelTwos => Set<LevelTwo>();

        public DbSet<LevelThree> LevelThrees => Set<LevelThree>();

        public DbSet<Triplet> Triplets => Set<Triplet>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            //Relacion de uno a uno entre Persona y User

            modelBuilder.Entity<User>()
                .HasOne(u => u.Employee)
                .WithOne(p => p.User)
                .HasForeignKey<User>(u => u.EmployeeId);


            // Relación muchos a uno: Triplet → LevelOne
            modelBuilder.Entity<Triplet>()
                .HasOne(t => t.LevelOne)
                .WithMany()
                .HasForeignKey(t => t.LevelOneId)
                .OnDelete(DeleteBehavior.Restrict);

            // Relación muchos a uno: Triplet → LevelTwo
            modelBuilder.Entity<Triplet>()
                .HasOne(t => t.LevelTwo)
                .WithMany()
                .HasForeignKey(t => t.LevelTwoId)
                .OnDelete(DeleteBehavior.Restrict);

            // Relación muchos a uno: Triplet → LevelThree
            modelBuilder.Entity<Triplet>()
                .HasOne(t => t.LevelThree)
                .WithMany()
                .HasForeignKey(t => t.LevelThreeId)
                .OnDelete(DeleteBehavior.NoAction);

        }

    }
}
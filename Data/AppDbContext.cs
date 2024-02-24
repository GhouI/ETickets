using eTickets.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using System.Reflection.Emit;

namespace eTickets.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<Actor_Movie>().HasKey(am => new
            {
                am.ActorId, 
                am.MovieId
            });
            model.Entity<Actor_Movie>().HasOne(movie => movie.Movie).WithMany(am => am.Actor_Movies).HasForeignKey(m => m.MovieId);
            model.Entity<Actor_Movie>().HasOne(movie => movie.Actor).WithMany(am => am.Actor_Movie).HasForeignKey(m => m.ActorId);

            base.OnModelCreating(model);
        }

        public Microsoft.EntityFrameworkCore.DbSet<Actor> Actor {  get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Movie> Movie { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Actor_Movie> Actor_Movie { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Cinema> Cinema { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Producer> Producer { get; set; }


    }
}

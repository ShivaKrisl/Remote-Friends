using Microsoft.EntityFrameworkCore;
using Remote_Friends.Data.DataContext.Models;
using Remote_Friends.DataContext.Models;

namespace Remote_Friends.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public virtual DbSet<Post> Posts { get; set; }

        public virtual DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // One - Many Relation
            modelBuilder.Entity<User>() // for a User 
                .HasMany(u => u.Posts) // can have multiple Posts
                .WithOne(p => p.user) // For each post has one user
                .HasForeignKey(p => p.UserId); // Identified by UserId 

        }

    }
}

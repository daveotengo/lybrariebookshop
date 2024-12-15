using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using lybrariebookshop.Models;

namespace lybrariebookshop.Data
{
    public class lybrariebookshopContext : DbContext
    {
        public lybrariebookshopContext (DbContextOptions<lybrariebookshopContext> options)
            : base(options)
        {
        }

        public DbSet<lybrariebookshop.Models.Author> Author { get; set; } = default!;
        public DbSet<lybrariebookshop.Models.Book> Book { get; set; } = default!;
        public DbSet<lybrariebookshop.Models.Genre> Genre { get; set; } = default!;

      /*  protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>()
                .HasOne(b => b.Author)
                .WithMany()
                .HasForeignKey(b => b.AuthorId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Book>()
                .HasOne(b => b.Genre)
                .WithMany()
                .HasForeignKey(b => b.GenreId)
                .OnDelete(DeleteBehavior.Restrict);
        }*/
    }
}

#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; } 
        //以下演示HasColumnType的用法
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Book>()
        //        .Property(b => b.Title).HasColumnType("varchar");
        //}
        //演示的实体类代码
        //public class Book
        //{
        //    public int BookId { get; set; }
        //    public string Title { get; set; }
        //    public Author Author { get; set; }
        //}

        //还有下面这种形式
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Order>()
        //        .Property(o => o.ExchangeRate).HasColumnType("decimal(5,3)");
        //}
    }
}

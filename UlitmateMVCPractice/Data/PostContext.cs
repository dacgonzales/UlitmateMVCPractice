using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;
using UlitmateMVCPractice.Models;

namespace UlitmateMVCPractice.Data
{
    public class PostContext:DbContext
    {
        public PostContext():base("DefaultConnection")
        { }
        public DbSet<Event> Events { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Comment>().HasKey(c => c.CommentId);
            modelBuilder.Entity<Event>().HasKey(c => c.EventId);
            modelBuilder.Entity<Event>().Property(e => e.EventId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Comment>().Property(e => e.CommentId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            
            modelBuilder.Entity<Event>()
                .HasMany<Comment>(e => e.CommentList)
                .WithRequired(e => e.Event)
                .HasForeignKey(e => e.EventId);            
        }
    }
}
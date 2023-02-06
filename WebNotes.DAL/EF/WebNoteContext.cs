using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebNotes.DAL.Entities;

namespace WebNotes.DAL.EF
{
    public class WebNoteContext : DbContext
    {
        public WebNoteContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data Source = DESKTOP-HB9SS2O\SQLEXPRESS;initial catalog = WebNoteDB;integrated security = True");
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Note> Notes { get; set; }

        public DbSet<Topic> Topics { get; set; }
    }
}

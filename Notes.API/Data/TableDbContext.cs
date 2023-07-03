using Microsoft.EntityFrameworkCore;

using Notes.API.Models.Entities;

namespace Notes.API.Data
{
    public class TableDbContext : DbContext
    {
        public TableDbContext(DbContextOptions<TableDbContext> options) : base(options)
        {
        }

        public DbSet<Event111> Event111s { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<User> Users { get; set; }

        public override int SaveChanges()
        {
            // Dodaj poniższe wiersze kodu, aby zapisać zmiany w bazie danych
            return base.SaveChanges();
        }
    }
}



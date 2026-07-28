using API.Maps;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DBContext :DbContext
    {
        public DBContext(DbContextOptions<DBContext> options): base(options) { }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   

            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new AuthorMap());
        }
    }
}

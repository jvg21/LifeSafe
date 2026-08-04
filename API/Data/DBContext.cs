using API.Maps;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DBContext :DbContext
    {
        public DBContext(DbContextOptions<DBContext> options): base(options) { }

        public DbSet<Folder> Folders { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Models.File> Files { get; set; }
        public DbSet<Url> Urls { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   

            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new AuthorMap());
            modelBuilder.ApplyConfiguration(new BookMap());
            modelBuilder.ApplyConfiguration(new FolderMap());
            modelBuilder.ApplyConfiguration(new FileMap());
            modelBuilder.ApplyConfiguration(new UrlMap());
        }
    }
}

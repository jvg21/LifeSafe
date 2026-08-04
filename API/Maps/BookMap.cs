using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Maps
{
    public class BookMap : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Book");

            builder.HasKey(b => b.Id);

            builder.Property(b => b.Name).HasMaxLength(80).IsRequired();

            //Many to Many Book_Author FK

            builder.HasMany(book => book.Authors).WithMany(author => author.Books).UsingEntity(j => j.ToTable("Book_Author"));
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Maps
{
    public class BookMap : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Book");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.Title).HasMaxLength(50).IsRequired();
        }
    }
}

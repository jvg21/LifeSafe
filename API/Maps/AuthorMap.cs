using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Maps
{
    public class AuthorMap : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.ToTable("Author");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.Name).HasMaxLength(80).IsRequired();
            builder.HasIndex(a => a.Name).IsUnique();

            //Many to Many Book_Author FK on the BookMap
        }
    }
}

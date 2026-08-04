using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace API.Maps
{
    public class UrlMap : IEntityTypeConfiguration<Url>
    {
        public void Configure (EntityTypeBuilder<Url> builder)
        {
            builder.ToTable("Url");
            builder.HasKey(u=> u.Id);

            builder.HasOne(u => u.Book).WithMany().HasForeignKey(u => u.Book_Id);
            builder.HasOne(u=> u.Author).WithMany().HasForeignKey(u => u.Author_Id);

        }
    }
}

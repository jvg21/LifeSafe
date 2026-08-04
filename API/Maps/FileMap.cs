using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Maps
{
    public class FileMap : IEntityTypeConfiguration<Models.File>
    {
        public void Configure(EntityTypeBuilder<Models.File> builder) {
            builder.ToTable("File");
            builder.HasKey(x => x.Id);

            builder.HasOne(f => f.Book).WithMany().HasForeignKey(f => f.Book_Id);
            builder.HasOne(f => f.Author).WithMany().HasForeignKey(f => f.Author_Id);

        }
    }
}

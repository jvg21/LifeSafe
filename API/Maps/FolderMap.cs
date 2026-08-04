using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API.Maps
{
    public class FolderMap: IEntityTypeConfiguration<Folder>
    {
        public void Configure(EntityTypeBuilder<Folder> builder)
        {
            builder.ToTable("Folder");

            builder.HasKey(f => f.Id);
            builder.Property(f => f.Id).UseIdentityColumn(seed: 1000);



            builder.HasData(
                new Folder { Id = 1, Name = "Author", ParentFolderId = null },
                new Folder { Id = 2, Name = "Book", ParentFolderId = null },
                new Folder { Id = 3, Name = "Comic", ParentFolderId = null },
                new Folder { Id = 4, Name = "Video", ParentFolderId = null },
                new Folder { Id = 5, Name = "Music", ParentFolderId = null },
                new Folder { Id = 6, Name = "Games", ParentFolderId = null }
            );


        }
    }
}

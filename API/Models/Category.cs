namespace API.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public bool? VideoCategory { get; set; }
        public bool? BookCategory { get; set; }
        public bool? AuthorCategory { get; set; }
        public bool? GameCategory { get; set; }
        public bool? ComicCategory { get; set; }
        public bool? DocumentCategory { get; set; }
        public bool? NoteCategory { get; set; }
        public bool? FolderCategory { get; set; }


        public Category(
            bool? VideoCategory = false,
            bool? BookCategory = false,
            bool? AuthorCategory = false,
            bool? GameCategory = false,
            bool? ComicCategory = false,
            bool? DocumentCategory = false,
            bool? NoteCategory = false,
            bool? FolderCategory = false
           )
        {
            this.VideoCategory = VideoCategory;
            this.BookCategory = BookCategory;
            this.AuthorCategory = AuthorCategory;
            this.GameCategory = GameCategory;
            this.ComicCategory = ComicCategory;
            this.DocumentCategory = DocumentCategory;
            this.NoteCategory = NoteCategory;
            this.FolderCategory = FolderCategory;
        }
    }
}

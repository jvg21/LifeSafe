namespace API.Models
{
    public class Url
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }

        //public int? VideoId { get; set; }
        public int? Book_Id { get; set; }
        public Book? Book { get; set; }
        public int? Author_Id { get; set; }
        public Author? Author { get; set; }
        //public int? GameId { get; set; }
        //public int? ComicId { get; set; }
        //public int? MusicId { get; set; }

        public Url(string Text)
        {
            this.Text = Text;
        }
    }
}

namespace API.Models;

using API.Utils;

public class File
{
    public int Id { get; set; }
    public string Extension { get; set; }
    public long? StorageBytes { get; set; }
    public Enum.StorageType StorageType { get; set; }
    public byte[]? Content { get; set; }
    public string? Path { get; set; }
    public int? Book_Id { get; set; }
    public Book? Book { get; set; }
    public int? Author_Id { get; set; }
    public Author? Author { get; set; }

    //public int? GameId { get; set; }
    //public int? ComicId { get; set; }
    //public int? VideoId { get; set; }


    public File()
    {

    }
}

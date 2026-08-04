namespace API.Models;
public class Author
{
    public Author(string Name)
    {
        this.Name = Name;
    }
    public int Id { get; set; }
	public string Name { get; set; }

    public ICollection<Book> Books { get; set; } = new List<Book>();

    public ICollection<Url> Urls { get; set; } = new List<Url>();

}

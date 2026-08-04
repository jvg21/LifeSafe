namespace API.Models;

public class Book
{
	public int Id { get; set; }
	public string Name { get; set; }

	public ICollection<Author> Authors { get; set; } = new List<Author>();
    public ICollection<Url> Urls { get; set; } = new List<Url>();

    public Book(string Name)
	{
		this.Name = Name;
	}


}

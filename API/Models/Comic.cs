namespace API.Models;

public class Comic
{
    public Comic(string name)
    {
        Name = name;
    }
    public int Id { get; set; }
	public string Name { get; set; }


}

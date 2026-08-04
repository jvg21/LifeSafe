namespace API.Models;

public class Video
{
    public Video(string name)
    {
        Name = name;
    }
    public int Id { get; set; }
	public string Name { get; set; }


}

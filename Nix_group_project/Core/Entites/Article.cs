namespace Core.Entites;
public sealed class Article
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Text { get; set; }

    // public List<Rating> Ratings { get; set; } = new List<Rating>();
    // public List<Comment> Comments { get; set; } = new List<Comment>();
}

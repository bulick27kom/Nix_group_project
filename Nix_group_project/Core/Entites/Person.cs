namespace Core.Entites;
public sealed class Person
{
    public int? Id { get; set; } 
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public bool IsActive { get; set; } = true;
    public string? ProfilePicture { get; set; }
   
    // public Cart? Cart { get; set; }
}

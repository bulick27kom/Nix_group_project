using Core.Entites;

namespace DataAccess;
public class Data
{
    private static Data? _data;
    public static Data Instance()
    {
        if (_data is null)
        {
            _data = new();
        }
        return _data;
    }
    private Data()
    {

    }
    public List<Person> People { get; set; } = new()
    {

        new Person()
        {
            Id = 1,
            FirstName ="Max",
            LastName ="Peterson",
            BirthDate = DateTime.Now,
        },
         new Person()
        {
            Id = 2,
            FirstName ="Goofy",
            LastName ="Bark",
            BirthDate = DateTime.Now.AddDays(-1),
        }
    };
    public List<Article> Articles { get; set; } = new()
    {

        new Article()
        {
            Id = 1,
            Title ="Max",
            Text ="Peterson",
        },
         new Article()
        {
            Id = 2,
            Text ="Goofy",
            Title ="Bark",            
        }
    };
}

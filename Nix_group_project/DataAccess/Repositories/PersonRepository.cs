using Core.Entites;
using Core.Interfaces;
using System;

namespace DataAccess.Repositories;
public class PersonRepository : IPersonRepository
{
    private readonly Data _data;

    public PersonRepository()
    {
        _data = Data.Instance();
    }

    public void Create(Person person)
    {
        _data.People.Add(person);
        Console.WriteLine("Person updated");
    }

    public void Delete(int id)
    {
        _data.People.SingleOrDefault(p => p.Id == id)!.IsActive = false;
        Console.WriteLine($"Person deleted {id}");
    }

    public List<Person> Get()
    {
        Console.WriteLine("People:");
        return _data.People.Where(p=>p.IsActive).ToList();
    }

    public Person Get(int id)
    {
        Console.WriteLine($"Person get by id: {id}");
        return _data.People.SingleOrDefault(p => p.Id == id)!;
    }

    public void Update(Person person)
    {
        Console.WriteLine("Person updated");
    }
}

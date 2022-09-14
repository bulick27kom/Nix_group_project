using Core.Entites;
using Core.Interfaces;
using DataAccess.Repositories;

namespace WebApi.Controllers;
public class PersonController
{
    private readonly IPersonRepository _personRepository;

    public PersonController()
    {
        _personRepository =(IPersonRepository) new PersonRepository();
    }

    public void Get()
    {
       var people = _personRepository.Get();
        foreach (var person in people)
        {
            Console.WriteLine($"Id: {person.Id}, Name: {person.FirstName} {person.LastName}");
        }
    }

    public void Get(int id)
    { 
        var person = _personRepository.Get(id);
        Console.WriteLine($"Id: {person.Id}, Name: {person.FirstName} {person.LastName}");
    }

    public void Delete(int id)
    {
        var person = _personRepository.Get(id);
        _personRepository.Delete(id);
        Console.WriteLine($"Id: {person.Id}, Name: {person.FirstName} {person.LastName}");
    }
    public void Update(Person person)
    {
        _personRepository.Update(person);
    }
    public void Create(Person person)
    {
        _personRepository.Create(person);
    }
}

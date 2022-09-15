using Core.Entites;

namespace Core.Interfaces;
public interface IPersonRepository
{
    public List<Person> Get();
    public Person Get(int id);
    public void Create(Person person);
    public void Update(Person person);
    public void Delete(int id);
}

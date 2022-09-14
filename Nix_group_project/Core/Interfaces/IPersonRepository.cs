using Core.Entites;

namespace Core.Interfaces;
public interface IPersonRepository
{
    public void Get();
    public void Get(int id);
    public void Create(Article article);
    public void Update(Article article);
    public void Delete(int id);
}

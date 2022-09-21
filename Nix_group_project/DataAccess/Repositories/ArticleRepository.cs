using Core.Entites;
using Core.Interfaces;
using System;

namespace DataAccess.Repositories;
public class ArticleRepository : IArticleRepository
{
    private readonly Data _data;
    public ArticleRepository()
    {
        _data = Data.Instance();
    }
    public void Create(Article article)
    {
        _data.Articles.Add(article);
        Console.WriteLine("article updated");
    }

    public void Delete(int id)
    {
        
        Console.WriteLine($"Person deleted {id}");
    }

    public List<Article> Get()
    {
        Console.WriteLine("articles:");
        return _data.Articles.ToList();
    }

    public Article Get(int id)
    {
        Console.WriteLine($"Person get by id: {id}");
        return _data.Articles.SingleOrDefault(p => p.Id == id)!;
    }

    public void Update(Article article)
    {
        Console.WriteLine("Person updated");
    }
}

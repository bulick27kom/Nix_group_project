using Core.Entites;
using Core.Interfaces;
using DataAccess.Repositories;

namespace WebApi.Controllers;
public class ArticleController
{
    private readonly IArticleRepository _articleRepository;
    public ArticleController()
    {
        _articleRepository = (IArticleRepository)new ArticleController();
    }
    public void Get()
    {
        var articles = _articleRepository.Get();
        foreach (var article in articles)
        {
            Console.WriteLine($"Id: {article.Id}, Name: {article.Title} {article.Text}");
        }
    }

    public void Get(int id)
    {
        var article = _articleRepository.Get(id);
        Console.WriteLine($"Id: {article.Id}, Name: {article.Title} {article.Text}");
    }

    public void Delete(int id)
    {
        var article = _articleRepository.Get(id);
        _articleRepository.Delete(id);
        Console.WriteLine($"Id: {article.Id}, Name: {article.Title} {article.Text}");
    }
    public void Update(Article article)
    {
        _articleRepository.Update(article);
    }
    public void Create(Article article)
    {
        _articleRepository.Create(article);
    }
}

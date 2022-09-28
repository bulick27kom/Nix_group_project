
using Core.Entites;
using WebApi.Controllers;

internal class Program
{
    private static void Main(string[] args)
    {
        PersonController personController = new PersonController();
        personController.Get();
        personController.Get(1);
        personController.Create(new Person()
        {
            Id=3,
            FirstName="test1"
        });
        personController.Delete(1);
        personController.Get();
        personController.Update(new Person());
        ArticleController articleController = new ArticleController();
        articleController.Get();
        articleController.Get(1);
        articleController.Create(new Article()
        {
            Id = 3,
            Title = "test1"
        });
        articleController.Delete(1);
        articleController.Get();
        articleController.Update(new Article());
    }

}
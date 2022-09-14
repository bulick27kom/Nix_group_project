
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
    }

}
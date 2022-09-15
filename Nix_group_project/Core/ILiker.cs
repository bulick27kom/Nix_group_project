using Core.Entites;

namespace Core
{
    public interface ILiker
    {

        int LikesCount { get; set; }
        int DislikesCount { get; set; }
        List<Person> UsersLikes { get; set; }

        bool AddLike(Person user);
        bool AddDislike(Person user);

     
    }

}

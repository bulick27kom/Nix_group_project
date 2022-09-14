namespace Core
{
    public interface ILiker
    {

        int LikesCount { get; set; }
        int DislikesCount { get; set; }
        List<User> UsersLikes { get; set; }

        bool AddLike(User user);
        bool AddDislike(User user);

     
    }

}

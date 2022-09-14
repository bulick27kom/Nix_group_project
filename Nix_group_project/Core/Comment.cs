using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Core
{

    internal class Comment : ILiker
    {

        #region Properties
        /// <summary>
        /// Коментируемый продукт
        /// </summary>
        public Product Product { get; set; }
        
        /// <summary>
        /// Текст коментария 
        /// </summary>
        public string Text { get; set; } = "";

        /// <summary>
        /// Дата создания коментария
        /// </summary>
        public DateTime CreatData { get; set; }

        /// <summary>
        /// Пользователь, который оставил коментарий
        /// </summary>
        public User User { get; private set; }

        /// <summary>
        /// Количество лайков
        /// </summary>
        public int LikesCount { get; set; } = 0;
        
        /// <summary>
        /// количество дизлайков
        /// </summary>
        public int DislikesCount { get ;  set; }
        
        /// <summary>
        /// Список лайкныуших пользователей. 
        /// Тольок авторизированный пользователь может поставить лайк или дизлайк
        /// и только один раз.
        /// </summary>
        public List<User> UsersLikes { get ;  set; }
        #endregion




        public Comment(Product product, string text, User user)
        {
            UsersLikes = new List<User>();
            Product = product;
            Text = text;
            CreatData = DateTime.Now;
            User = user;
        }

        public bool AddLike(User user)
        {
            
            if (UsersLikes.Contains(user))
                return false;
            else 
            {
                UsersLikes.Add(user);
                LikesCount++;
                return true;
            }
        }

        public bool AddDislike(User user)
        {
            if (UsersLikes.Contains(user))            
                return false;
            else
            {
                UsersLikes.Add(user);
                DislikesCount++;
                return true;
            }
        }

    }


    // Заглушки для не существующих типов
    public class User { }
    public class Product { }

}

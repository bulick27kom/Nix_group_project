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
        #region Fields
        private List<Like> _likes;
        private List<Like> _dislikes;
        #endregion

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
        #endregion




        public Comment(Product product, string text, User user)
        {
            _likes = new List<Like>();
            _dislikes = new List<Like>();
            Product = product;
            Text = text;
            CreatData = DateTime.Now;
            User = user;
        }

        public bool AddLike(User user)
        {
            Like like = new Like(user);
            if (_likes.Contains(like))
                return false;
            else 
            {
                _likes.Add(like);
                return true;
            }
        }

        public bool AddDislike(User user)
        {
            Like dislike = new Like(user);
            if (_dislikes.Contains(dislike))
                return false;
            else
            {
                _dislikes.Add(dislike);
                return true;
            }
        }

        public int CounLikes()
        {
            return _likes.Count;
        }

        public int CounDisikes()
        {
            return _dislikes.Count;
        }
    }

    class Like 
    {
        public User User { get; private set; }
        public Like(User user)
        {
            User = user;
        }
    }

    interface ILiker
    {
        bool AddLike(User user);
        bool AddDislike(User user);

        int CounLikes();
        int CounDisikes();
    }


    // Заглушки для не существующих типов
    class User { }
    class Product { }

}

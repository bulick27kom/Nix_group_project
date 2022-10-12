using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entites
{
    public class Like
    {
        int ID { get; set; }
        public int LikesCount { get; set; } 

        public int DislikesCount { get; set; }

        public List<Person> UsersLikes { get; set; }
    }
}

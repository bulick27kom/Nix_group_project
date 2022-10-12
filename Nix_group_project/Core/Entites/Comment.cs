using Core.Entites;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Core
{

    public class Comment 
    {

        public int Id { get; set; }

        public string Text { get; set; };

        public DateTime CreatData { get; set; }

        public Person User { get;  set; }

        public int LikeId { get; set; }
        public Like Like { get; set; }

       

    }

}

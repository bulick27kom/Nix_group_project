using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entites
{
    internal class Order
    {
        public int Id { get; set; }
        public Person Person { get; set; }
        public DateTime TimeOrder { get; set; }
        public List<Product> Products { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upteka.DAL.Entity
{
    public class OrderProduct
    {
        public Order Order { get; set; }

        public Product Product { get; set; }

        public int Count { get; set; }
    }
}

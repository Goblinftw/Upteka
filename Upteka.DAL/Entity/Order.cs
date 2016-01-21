using System;
using System.Collections.Generic;

namespace Upteka.DAL.Entity
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public IList<OrderProduct> OrderProducts { get; set; }
    }
}
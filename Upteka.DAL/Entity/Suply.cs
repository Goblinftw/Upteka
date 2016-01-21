using System;
using System.Collections.Generic;

namespace Upteka.DAL.Entity
{
    public class Suply
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public IList<Product> Products { get; set; }
    }
}
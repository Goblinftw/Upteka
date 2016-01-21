using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upteka.DAL.Entity
{
    public class SuplyProduct
    {
        public Suply Suply { get; set; }

        public Product Product { get; set; }
    }
}

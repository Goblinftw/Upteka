using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Upteka.DAL.Entity;

namespace Upteka.DAL
{
     public partial class UptekaContext : DbContext, IDbContext
    {
        public UptekaContext()
            : base("DBConnection")
        {
        }

        public virtual DbSet<Product> Products { get; set; }
    }
}

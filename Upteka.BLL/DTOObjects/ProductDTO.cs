using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upteka.BLL.DTOObjects
{
    public class ProductDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string BarCode { get; set; }

        public int InStock { get; set; }
    }
}

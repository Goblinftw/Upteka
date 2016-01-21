using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Upteka.BLL.DTOObjects;
using Upteka.DAL.Entity;

namespace Upteka.BLL.Services.Interfaces
{
    public interface IProductService
    {
        IEnumerable<ProductDTO> GetAll();

        ProductDTO Find(int id);

        void Add(ProductDTO product);

        void Update(ProductDTO product);

        void Delete(int id);
    }
}

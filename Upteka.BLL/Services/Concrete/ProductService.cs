using System;
using System.Collections.Generic;
using Upteka.BLL.DTOObjects;
using Upteka.BLL.Services.Interfaces;
using Upteka.DAL;
using Upteka.DAL.Entity;
using AutoMapper;
namespace Upteka.BLL.Services.Concrete
{ 
    public class ProductService : IProductService
    {
        private readonly IDbContext m_context;

        public ProductService(IDbContext context)
        {
            m_context = context;
        }

        public IEnumerable<ProductDTO> GetAll()
        {
            var a = m_context.Set<Product>();
            return Mapper.Map<IEnumerable<ProductDTO>>(a);
        }

        public ProductDTO Find(int id)
        {
            return Mapper.Map<ProductDTO>(m_context.Set<Product>().Find(id));
        }

        public int Add(ProductDTO product)
        {
            throw new NotImplementedException();
        }

        public void Update(ProductDTO product)
        {
            throw new NotImplementedException();
        }

        public void Delete(ProductDTO product)
        {
            throw new NotImplementedException();
        }
    }
}

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

        public void Add(ProductDTO product)
        {
            m_context.Set<Product>().Add(Mapper.Map<Product>(product));
            m_context.SaveChanges();
        }

        public void Update(ProductDTO product)
        {
            Product entity = m_context.Set<Product>().Find(product.Id);
            if (entity == null)
                throw new InvalidOperationException("Entity not found during Edit operation");

            m_context.Entry(entity).CurrentValues.SetValues(product);
            m_context.SaveChanges();
        }

        public void Delete(int id)
        {
            Product entity = m_context.Set<Product>().Find(id);
            m_context.Set<Product>().Remove(entity);
            m_context.SaveChanges();
        }
    }
}

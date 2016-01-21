using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Upteka.BLL.DTOObjects;
using Upteka.DAL.Entity;

namespace Upteka.BLL.Infrastructure
{
    public static class AutomapperInit
    {
        public static void Load()
        {
            Mapper.CreateMap<Product, ProductDTO>();
            Mapper.CreateMap<ProductDTO, Product>();
        }

    }
}

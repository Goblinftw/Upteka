using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Upteka.BLL.Services.Concrete;
using Upteka.BLL.Services.Interfaces;
using Upteka.DAL.Infrastructure;
namespace Upteka.BLL.Infrastructure
{
    public class BllModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule(new DalModule());
            builder.RegisterType<ProductService>().As<IProductService>();
        }
    }
}

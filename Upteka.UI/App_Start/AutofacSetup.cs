using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using Autofac.Integration.Mvc;
using Upteka.BLL.Infrastructure;

namespace Upteka.App_Start
{
    internal static class AutofacSetup
    {
        private static IContainer _container;

        internal static IContainer Setup()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof (AutofacSetup).Assembly);
            builder.RegisterModule(new BllModule());

            _container = builder.Build();

            return _container;
        } 
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Factory_Demo
{
    public class RegisterDI
    {
        private static IContainer Container { get; set; }
        public static TInterface Register<TService, TInterface>()
        {
            var Builder = new ContainerBuilder();
            Builder.RegisterType<TService>().As<TInterface>();
            Container = Builder.Build();
            var Factory = Container.Resolve<TInterface>();
            return Factory;
        }
    }
}
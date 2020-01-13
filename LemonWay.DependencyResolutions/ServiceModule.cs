using Autofac;
using LemonWay.Service;
using LemonWay.Service.Interfaces;

namespace LemonWay.DependencyResolutions
{
    public class ServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<FibonacciService>().As<IFibonacciService>();
            builder.RegisterType<XmlToJsonService>().As<IXmlToJsonService>();
        }
    }
}

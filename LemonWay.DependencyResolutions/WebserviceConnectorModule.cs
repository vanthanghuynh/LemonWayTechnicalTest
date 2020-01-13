using Autofac;
using LemonWay.WebServiceConnector;

namespace LemonWay.DependencyResolutions
{
    public class WebserviceConnectorModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<LemonWayWSConnector>().As<ILemonWayWSConnector>();
        }
    }
}

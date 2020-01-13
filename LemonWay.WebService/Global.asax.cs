using Autofac;
using Autofac.Integration.Web;
using LemonWay.DependencyResolutions;
using log4net;
using System;
using System.Web;

namespace LemonWay.WebService
{
    public class Global : HttpApplication, IContainerProviderAccessor
    {
        static IContainerProvider _containerProvider;
        private static readonly ILog _log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public IContainerProvider ContainerProvider
        {
            get { return _containerProvider; }
        }

        void Application_Start(object sender, EventArgs e)
        {
            log4net.Config.XmlConfigurator.Configure();
            _log.Info("start webservice");

            var builder = new ContainerBuilder();
            builder.RegisterModule(new ServiceModule());
            _containerProvider = new ContainerProvider(builder.Build());
        }
    }
}
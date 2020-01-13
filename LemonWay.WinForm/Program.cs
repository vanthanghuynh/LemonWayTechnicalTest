using Autofac;
using LemonWay.DependencyResolutions;
using System;
using System.Windows.Forms;

namespace LemonWay.WinForm
{
    public static class Program
    {
        public static IContainer _container;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterModule(new WebserviceConnectorModule());
            _container = containerBuilder.Build();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}

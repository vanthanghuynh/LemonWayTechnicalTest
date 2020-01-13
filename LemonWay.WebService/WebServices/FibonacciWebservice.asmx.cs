using Autofac;
using Autofac.Integration.Web;
using LemonWay.Service.Interfaces;
using LemonWay.WebService.WebServiceReponse;
using log4net;
using System;
using System.Threading;
using System.Web;
using System.Web.Services;

namespace LemonWay.WebService.WebServices
{
    /// <summary>
    /// Summary description for FibonacciWebservice
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class FibonacciWebservice : System.Web.Services.WebService
    {
        private readonly ILog _log;
        public IFibonacciService _fibonacciService { get; set; }

        public FibonacciWebservice()
        {
            _log = LogManager.GetLogger(GetType());

            var cpa = (IContainerProviderAccessor)HttpContext.Current.ApplicationInstance;
            var cp = cpa.ContainerProvider;
            cp.RequestLifetime.InjectProperties(this);
        }

        [WebMethod]
        public WebServiceReponse<int> ComputeFibonacci(int number)
        {
            _log.Info(string.Format("ComputeFibonacci({0})",number));

            WebServiceReponse<int> reponse = new WebServiceReponse<int>();
            
            try
            {
                Thread.Sleep(2000);
                reponse.Result = _fibonacciService.ComputeFibonacci(number);

                _log.Info(string.Format("Result: {0}", reponse.Result));
            }
            catch (Exception ex)
            {
                reponse.AddMessage(ex.Message, MessageType.Error);

                _log.Error(ex);
            }

            return reponse;
        }
    }
}

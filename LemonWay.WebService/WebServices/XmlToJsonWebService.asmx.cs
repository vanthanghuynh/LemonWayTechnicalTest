using Autofac;
using Autofac.Integration.Web;
using LemonWay.Service.Interfaces;
using LemonWay.WebService.WebServiceReponse;
using log4net;
using System;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

namespace LemonWay.WebService.WebServices
{
    /// <summary>
    /// Summary description for XmlToJsonWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class XmlToJsonWebService : System.Web.Services.WebService
    {
        private readonly ILog _log;
        public IXmlToJsonService _xmlToJsonService { get; set; }

        public XmlToJsonWebService()
        {
            _log = LogManager.GetLogger(GetType());

            var cpa = (IContainerProviderAccessor)HttpContext.Current.ApplicationInstance;
            var cp = cpa.ContainerProvider;
            cp.RequestLifetime.InjectProperties(this);
        }

        [WebMethod]
        public WebServiceReponse<string> XmlToJson(string xmlStr)
        {
            _log.Info(string.Format("XmlToJson: {0}", xmlStr));

            WebServiceReponse<string> reponse = new WebServiceReponse<string>();

            try
            {
                reponse.Result = _xmlToJsonService.XmlToJson(xmlStr);

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

using LemonWay.WebServiceConnector.FibonacciWSRef;
using LemonWay.WebServiceConnector.XmlToJsonWSRef;
using System.Threading.Tasks;

namespace LemonWay.WebServiceConnector
{
    public class LemonWayWSConnector : ILemonWayWSConnector
    {
        public async Task<WebServiceReponseOfInt32> ComputeFibonnaciAsync(int n)
        {
            using (var client = new FibonacciWebserviceSoapClient())
            {
                var reponse = await client.ComputeFibonacciAsync(n);

                return reponse.Body.ComputeFibonacciResult;
            }
        }

        public async Task<WebServiceReponseOfString> XmlToJsonAsync(string xmlStr)
        {
            using (var client = new XmlToJsonWebServiceSoapClient())
            {
                var reponse = await client.XmlToJsonAsync(xmlStr);

                return reponse.Body.XmlToJsonResult;
            }
        }
    }
}

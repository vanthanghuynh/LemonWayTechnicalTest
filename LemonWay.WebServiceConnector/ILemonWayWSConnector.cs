using LemonWay.WebServiceConnector.FibonacciWSRef;
using LemonWay.WebServiceConnector.XmlToJsonWSRef;
using System.Threading.Tasks;

namespace LemonWay.WebServiceConnector
{
    public interface ILemonWayWSConnector
    {
        Task<WebServiceReponseOfInt32> ComputeFibonnaciAsync(int n);

        Task<WebServiceReponseOfString> XmlToJsonAsync(string xmlStr);
    }
}

using LemonWay.Service.Interfaces;
using Newtonsoft.Json;
using System.Xml;
using LemonWay.Service.Extensions;

namespace LemonWay.Service
{
    public class XmlToJsonService : IXmlToJsonService
    {
        public string XmlToJson(string xmlStr)
        {
            try
            {
                XmlDocument doc = new XmlDocument();

                doc.LoadXml(xmlStr);
                doc.FirstChild.RemoveAllAtributes();

                var format = new Newtonsoft.Json.Formatting();
                return JsonConvert.SerializeXmlNode(doc, format);
            }
            catch
            {
                return "Bad Xml format";
            }
        }

        public void RemoveAlltributes(XmlNode node)
        {
            if(node.Attributes != null)
                node.Attributes.RemoveAll();

            if (node.HasChildNodes)
                RemoveAlltributes(node.FirstChild);
        }

    }
}

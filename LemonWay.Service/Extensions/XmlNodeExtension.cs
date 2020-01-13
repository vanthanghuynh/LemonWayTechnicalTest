using System.Xml;

namespace LemonWay.Service.Extensions
{
    public static class XmlNodeExtension
    {
        public static void RemoveAllAtributes(this XmlNode node)
        {
            if (node == null)
                return;

            if (node.Attributes != null)
                node.Attributes.RemoveAll();

            if (node.HasChildNodes)
            {
                for (int i = 0; i < node.ChildNodes.Count; i++)
                    node.ChildNodes[i].RemoveAllAtributes();
            }
        }
    }
}

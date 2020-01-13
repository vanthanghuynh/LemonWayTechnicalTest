using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LemonWay.WebService.WebServiceReponse
{
    public enum MessageType
    {
        Info,
        Warning,
        Error
    }

    public class ReponseMessage
    {
        public MessageType Type { get; set; }
        public string Message { get; set; }
    }
}
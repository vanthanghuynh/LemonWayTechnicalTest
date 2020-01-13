using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LemonWay.WebService.WebServiceReponse
{
    public class WebServiceReponse <T>
    {
        public T Result { get; set; }
        public List<ReponseMessage> Messages { get; set; }

        public void AddMessage(string message, MessageType type)
        {
            if (Messages == null)
                Messages = new List<ReponseMessage>();

            Messages.Add(new ReponseMessage()
            {
                Message = message,
                Type = type
            });
        }
    }
}
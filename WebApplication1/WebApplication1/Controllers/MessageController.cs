using WebApplication1.queu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json.Linq;

namespace WebApplication1.Controllers
{

    [RoutePrefix(PREFIX)]
    public class MessageController : ApiController
    {
        const string PREFIX = "queue";
        const string COMMONPATH_MSG = "messagge" ;

        [HttpPost]
        [Route(COMMONPATH_MSG+"/{QueueName}/{Message}")]
        public JObject AddMessage(string QueueName, string Message)
        {
            QueuManager.GetQueueManager().AddMessageInQueue(QueueName, Message);

            JObject ToReturn = new JObject();

            ToReturn.Add(new JProperty("name", QueueName));
            ToReturn.Add(new JProperty("message", Message));

            return new JObject(new JProperty("added", ToReturn));
        }

        [HttpGet]
        [Route(COMMONPATH_MSG + "/{QueueName}")]
        public JObject GetMessagge(string QueueName)
        {
            string Messagge = QueuManager.GetQueueManager().GetMessageInQueue(QueueName);
            JObject ToReturn = new JObject();

            ToReturn.Add(new JProperty("name", QueueName));
            ToReturn.Add(new JProperty("message", Messagge));

            return new JObject(new JProperty("queue", ToReturn));
        }


        [HttpGet]
        [Route("queues")]
        public JObject GetQueue()
        {
            return  QueuManager.GetQueueManager().GetQueues();
        }


    }
}

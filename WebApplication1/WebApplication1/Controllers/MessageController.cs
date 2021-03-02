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

            return JObject.Parse("{ 'added' : { '" + QueueName + "':'" + Message + "'}}");
        }

        [HttpGet]
        [Route(COMMONPATH_MSG + "/{QueueName}")]
        public JObject GetMessagge(string QueueName)
        {
            string Messagge = QueuManager.GetQueueManager().GetMessageInQueue(QueueName);

            return JObject.Parse("{ 'message' : { '" + QueueName + "':'" + Messagge + "'}}");
        }


        [HttpGet]
        [Route("queues")]
        public JObject GetQueue()
        {
            return JObject.Parse( QueuManager.GetQueueManager().GetQueues());
        }


    }
}

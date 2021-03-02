using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace WebApplication1.queu
{
    class QueuManager
    {
        private static QueuManager qm;
        private static ConnectionFactory factory;
        private static IConnection connection;
        private static Dictionary<string, IModel> channels = new Dictionary<string, IModel>();

        private static ConnectionFactory GetFactory()
        {
            if (factory == null)
                factory = new ConnectionFactory() {
                    HostName = "localhost"
                };

            return factory;
        }

        private static IConnection GetConnection()
        {
            if (connection == null)
                connection = GetFactory().CreateConnection();

            return connection;
        }

        public static QueuManager GetQueueManager()
        {
            if (qm == null)
                qm = new QueuManager();

            return qm;
        }


        private QueuManager()
        {
            // TODO aniadir lectura de colas actuales en el servidor
        }

        private IModel AddChannel(string ChannelName)
        {
            IModel NewChannel = GetConnection().CreateModel();
            NewChannel.QueueDeclare(queue: ChannelName,
                                    durable: false,
                                    exclusive: false,
                                    autoDelete: false,
                                    arguments: null);

            channels.Add(ChannelName, NewChannel);

            return NewChannel;
        }

        public void AddMessageInQueue(string Queu, string Message)
        {
            IModel Channel;
            if ( ! channels.TryGetValue(Queu, out Channel))
            {
                Channel = AddChannel(Queu);
            }

            Channel.BasicPublish("", Queu, null, Encoding.UTF8.GetBytes(Message));
        }


        public string GetMessageInQueue(string QueueName)
        {
            IModel Channel;
            if (!channels.TryGetValue(QueueName, out Channel))
                return "No Queue find";

            string Message = Encoding.UTF8.GetString(Channel.BasicGet(QueueName, true).Body.ToArray());
            //Channel.BasicConsume(QueueName, true, null);
            return Message;
        }


        public JObject GetQueues()
        {
            JArray QueuesForJson = new JArray();

            foreach ( string ChannelI in channels.Keys)
            {
                IModel ch;
                channels.TryGetValue(ChannelI, out ch);
                uint nMess = ch.MessageCount(ChannelI);
                JObject QueuForJson = new JObject();
                QueuForJson.Add(new JProperty("name", ChannelI));
                QueuForJson.Add(new JProperty("messages", nMess));
                QueuesForJson.Add(QueuForJson);

            }

            return new JObject(new JProperty("queues", QueuesForJson));
        }


    }
}

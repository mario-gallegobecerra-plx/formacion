using System;
using System.Collections.Generic;
using System.Text;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace ConsoleApp1.queu
{
    class QueuManager
    {
        private static ConnectionFactory factory;
        private static string host = "127.0.0.1";
        private static IConnection connection;
        private static Dictionary<string, IModel> channels;

        private static ConnectionFactory GetFactory()
        {
            if (factory == null)
                factory = new ConnectionFactory() { HostName = host };

            return factory;
        }

        private static IConnection GetConnection()
        {
            if (connection == null)
                connection = GetFactory().CreateConnection();

            return connection;
        }



        private QueuManager() { }


        public void AddMessageInQueu(string Queu, string Message)
        {
            IModel Channel;
            channels.TryGetValue(Queu, out Channel);

            Channel.BasicPublish("", Queu + Channel.ChannelNumber, null, Encoding.UTF8.GetBytes(Message));
        }

    }
}

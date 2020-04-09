using Autofac;
using SocketLabs.InjectionApi;
using Thandizo.Messaging.Core;
using Thandizo.Messaging.Email;

namespace Thandizo.Email.ClientWorker.Modules
{
    public class ServiceModule : Module
    {
        private readonly int _serverId;
        private readonly string _apiKey;

        public ServiceModule(int serverId, string apiKey)
        {
            _serverId = serverId;
            _apiKey = apiKey;
        }
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<SocketLabsClient>()
                .As<ISocketLabsClient>()
                 .WithParameter("serverId", _serverId)
                 .WithParameter("apiKey", _apiKey);
            builder.RegisterType<EmailMessagingService>()
                .As<IMessagingService>();
                
        }
    }
}

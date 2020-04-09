using MassTransit;
using System.Threading.Tasks;
using Thandizo.DataModels.Contracts;
using Thandizo.Messaging.Core;

namespace Thandizo.Email.ClientWorker.Consumers
{
    public class EmailConsumer : IConsumer<IMessageModelRequest>
    {
        private readonly IMessagingService _service;

        public EmailConsumer(IMessagingService service)
        {
            _service = service;
        }
        public async Task Consume(ConsumeContext<IMessageModelRequest> context)
        {
            var request = context.Message;
            var response = await _service.SendMessage(request.Message);
            await context.RespondAsync(response);
        }
    }
}

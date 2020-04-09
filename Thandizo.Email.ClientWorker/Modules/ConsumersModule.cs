using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using Thandizo.Email.ClientWorker.Consumers;

namespace Thandizo.Email.ClientWorker.Modules
{
    public class ConsumersModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EmailConsumer>();
        }
    }
}

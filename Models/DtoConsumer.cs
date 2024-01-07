using API.Test;
using MassTransit;

namespace Test.Models
{
    public class DtoConsumer : IConsumer<DTO>
    {
        private readonly ILogger<DtoConsumer> logger;

        public DtoConsumer(ILogger<DtoConsumer> logger)
        {
            this.logger = logger;
        }

        public Task Consume(ConsumeContext<DTO> context)
        {
            logger.LogInformation($"Hello {context.Message.id} with name: {context.Message.name}");
            return Task.CompletedTask;   
        }
    }

    public class DtoConsumerDefinition: ConsumerDefinition<DtoConsumer>
    {
        protected override void ConfigureConsumer(IReceiveEndpointConfigurator endpointConfigurator, IConsumerConfigurator<DtoConsumer> consumerConfigurator,
            IRegistrationContext context)
        {
            endpointConfigurator.ConfigureConsumeTopology = false;
            endpointConfigurator.ClearSerialization();
            endpointConfigurator.UseJsonDeserializer();

            if(endpointConfigurator is IRabbitMqReceiveEndpointConfigurator rabbitMq)
            {
                rabbitMq.Bind("test");
            }
        }


    }
}

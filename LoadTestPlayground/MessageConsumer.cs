using MassTransit;

public class MessageConsumer : IConsumer<MessageCommand>
{
    public Task Consume(ConsumeContext<MessageCommand> context)
    {
        throw new NotImplementedException();
    }
}
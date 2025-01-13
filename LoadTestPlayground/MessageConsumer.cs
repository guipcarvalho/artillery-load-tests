using LoadTestPlayground;
using LoadTestPlayground.Data;
using MassTransit;

public class MessageConsumer(DbContext dbContext) : IConsumer<MessageCommand>
{
    public async Task Consume(ConsumeContext<MessageCommand> context)
    {
        var message = new Message
        {
            UserId = context.Message.UserId,
            Text = context.Message.Message,
            Score = context.Message.Score
        };

        dbContext.Messages.Add(message);
        await dbContext.SaveChangesAsync();
    }
}
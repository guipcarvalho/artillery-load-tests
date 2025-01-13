using System.ComponentModel.DataAnnotations;

namespace LoadTestPlayground.Data;

public class Message
{
    public long Id { get; init; }
    
    [MaxLength(100)]
    public required string UserId { get; init; }
    
    [MaxLength(1000)]
    public required string Text { get; init; }
    
    public long Score { get; init; }
}
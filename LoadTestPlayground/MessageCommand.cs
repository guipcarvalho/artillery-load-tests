namespace LoadTestPlayground;

public record MessageCommand
{
    public string UserId { get; set; }
    public string Message { get; set; }
    public long Score { get; set; }
}
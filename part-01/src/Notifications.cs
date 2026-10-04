namespace RefactoringLab;

public class Notification
{
    private readonly INotificationChannel _channel;
    private readonly bool _urgent;

    public Notification(
        INotificationChannel channel,
        bool urgent = false)
    {
        _channel = channel;
        _urgent = urgent;
    }

    public void Send(string to, string message)
    {
        if (_urgent)
        {
            message = $"[URGENT] {message}";
        }

        _channel.Send(to, message);
    }

    public void Schedule(
        string to,
        string message,
        DateTime sendAt)
    {
        if (_urgent)
        {
            message = $"[URGENT] {message}";
        }

        _channel.Schedule(to, message, sendAt);
    }
}
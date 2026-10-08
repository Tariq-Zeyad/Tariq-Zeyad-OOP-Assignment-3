namespace RefactoringLab;

public class SmsNotificationChannel : INotificationChannel
{
    public void Send(string to, string message)
    {
        Console.WriteLine($"[sms] {to}: {message}");
    }

    public void Schedule(string to, string message, DateTime sendAt)
    {
        Console.WriteLine(
            $"[sms scheduled {sendAt:g}] {to}: {message}");
    }
}
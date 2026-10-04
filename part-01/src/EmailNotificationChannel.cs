namespace RefactoringLab;

public class EmailNotificationChannel : INotificationChannel
{
	public void Send(string to, string message)
	{
		Console.WriteLine($"[email] {to}: {message}");
	}

	public void Schedule(string to, string message, DateTime sendAt)
	{
		Console.WriteLine(
			$"[email scheduled {sendAt:g}] {to}: {message}");
	}
}
using System;
namespace RefactoringLab;

public interface INotificationChannel
{
    void Send(string to, string message);

    void Schedule(string to, string message, DateTime sendAt);
}
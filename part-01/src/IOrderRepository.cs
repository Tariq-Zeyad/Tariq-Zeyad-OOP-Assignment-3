using System;
namespace RefactoringLab;


public interface IOrderRepository
{
    void Save(int orderId, DateTime processedAt);
}
public interface IEmailSender
{
    void Send(string to, string body);
}
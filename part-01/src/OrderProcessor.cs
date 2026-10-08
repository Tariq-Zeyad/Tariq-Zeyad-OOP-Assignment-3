namespace RefactoringLab;

public class OrderProcessor
{
    private readonly IOrderRepository _orderRepository;
    private readonly IEmailSender _emailSender;

    public OrderProcessor(
        IOrderRepository orderRepository,
        IEmailSender emailSender)
    {
        _orderRepository = orderRepository;
        _emailSender = emailSender;
    }

    public void Process(int orderId, string customerEmail)
    {
        var processedAt = DateTime.Now;

        _orderRepository.Save(orderId, processedAt);

        _emailSender.Send(
            customerEmail,
            $"Order {orderId} confirmed at {processedAt}");
    }
}
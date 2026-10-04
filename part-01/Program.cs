using RefactoringLab;

var shipping = new ShippingCostCalculator(
    new IShippingCarrier[]
    {
        new AramexCarrier(),
        new FedExCarrier(),
        new DHLCarrier()
    });

Console.WriteLine($"Aramex 2kg → {shipping.Calculate("Aramex", 2)}");
Console.WriteLine($"FedEx 2kg  → {shipping.Calculate("FedEx", 2)}");
Console.WriteLine();

var orderRepository = new SqlOrderRepository();
var emailSender = new SmtpEmailSender();

var processor = new OrderProcessor(orderRepository, emailSender);
processor.Process(1001, "customer@example.com");
Console.WriteLine();

var urgentScheduledEmail =
    new Notification(new EmailNotificationChannel(), urgent: true);

urgentScheduledEmail.Schedule(
    "customer@example.com",
    "Your order ships tomorrow",
    DateTime.Today.AddHours(18));

var urgentSms =
    new Notification(new SmsNotificationChannel(), urgent: true);

urgentSms.Send(
    "+201000000000",
    "OTP 4821");
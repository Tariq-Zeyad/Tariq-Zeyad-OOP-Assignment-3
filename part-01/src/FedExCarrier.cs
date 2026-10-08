using System;
namespace RefactoringLab;

public class FedExCarrier : IShippingCarrier
{
    public string Name => "FedEx";
    public decimal CalculateShippingCost(decimal weightKg) => weightKg * 15m;

}

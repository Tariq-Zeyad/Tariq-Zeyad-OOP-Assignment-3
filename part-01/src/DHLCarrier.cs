using System;
namespace RefactoringLab;

public class DHLCarrier : IShippingCarrier
{
    public string Name => "DHL";
    public decimal CalculateShippingCost(decimal weightKg) => weightKg * 18m;
}

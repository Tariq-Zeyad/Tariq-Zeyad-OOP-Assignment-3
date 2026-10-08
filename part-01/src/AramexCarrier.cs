using System;
namespace RefactoringLab;

public class AramexCarrier : IShippingCarrier
{
	public string Name => "Aramex";
	public decimal CalculateShippingCost(decimal weightKg) => weightKg * 12m;
}

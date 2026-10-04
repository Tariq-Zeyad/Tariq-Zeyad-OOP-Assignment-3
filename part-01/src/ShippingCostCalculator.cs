namespace RefactoringLab;

public class ShippingCostCalculator
{
    private readonly IEnumerable<IShippingCarrier> _carriers;

    public ShippingCostCalculator(IEnumerable<IShippingCarrier> carriers)
    {
        _carriers = carriers;
    }

    public decimal Calculate(string carrier, decimal weightKg)
    {
        foreach (var shippingCarrier in _carriers)
        {
            if (shippingCarrier.Name == carrier)
            {
                return shippingCarrier.CalculateShippingCost(weightKg);
            }
        }

        throw new ArgumentException($"Unknown carrier: {carrier}");
    }
}
namespace RefactoringLab;

public interface IShippingCarrier
{
    string Name { get; }
    decimal CalculateShippingCost(decimal weightKg);
}
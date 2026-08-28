namespace Sandbox;

/// <summary>
/// Works out what a customer actually pays for an order.
/// </summary>
public class OrderTotalCalculator
{
    public decimal CalculateTotal(decimal subtotal, string? discountCode)
    {
        // Discount codes are not handled yet - see issue #3.
        return subtotal;
    }
}

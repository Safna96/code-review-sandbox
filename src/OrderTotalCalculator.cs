namespace Sandbox;

/// <summary>
/// Works out what a customer actually pays for an order.
/// </summary>
public class OrderTotalCalculator
{
    private static readonly Dictionary<string, decimal> DiscountCodes = new()
    {
        ["SAVE10"] = 0.10m,
        ["SAVE25"] = 0.25m,
        ["STAFF50"] = 0.50m,
    };

    public decimal CalculateTotal(decimal subtotal, string? discountCode)
    {
        if (string.IsNullOrWhiteSpace(discountCode))
        {
            return subtotal;
        }

        if (!DiscountCodes.TryGetValue(discountCode.ToUpper(), out var rate))
        {
            return subtotal;
        }

        var discounted = subtotal - (subtotal * rate);

        var appliedAt = DateTime.Now;

        return discounted;
    }
}

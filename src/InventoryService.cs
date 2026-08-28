namespace Sandbox;

/// <summary>
/// Holds stock levels and reserves items against incoming orders.
/// </summary>
public class InventoryService
{
    private readonly Dictionary<string, int> _available = new();
    private readonly List<Reservation> _reservations = new();

    public void SetStock(string sku, int quantity) => _available[sku] = quantity;

    public int GetAvailable(string sku) => _available.TryGetValue(sku, out var q) ? q : 0;

    public IReadOnlyList<Reservation> Reservations => _reservations;

    public bool ReserveStock(string sku, int quantity)
    {
        if (quantity <= 0)
        {
            return false;
        }

        var available = GetAvailable(sku);
        if (quantity > available)
        {
            return false;
        }

        _available[sku] = available - quantity;

        _reservations.Add(new Reservation(sku, quantity, DateTime.Now));

        return true;
    }
}

public record Reservation(string Sku, int Quantity, DateTime ReservedAt);

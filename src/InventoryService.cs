namespace Sandbox;

/// <summary>
/// Holds stock levels and reserves items against incoming orders.
/// </summary>
public class InventoryService
{
    private readonly Dictionary<string, int> _available = new();

    public void SetStock(string sku, int quantity) => _available[sku] = quantity;

    public int GetAvailable(string sku) => _available.TryGetValue(sku, out var q) ? q : 0;

    public bool ReserveStock(string sku, int quantity)
    {
        // Reservations are not implemented yet - see issue #5.
        return false;
    }
}

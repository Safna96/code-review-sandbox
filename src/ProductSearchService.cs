namespace Sandbox;

/// <summary>
/// Searches the product catalogue and returns one page of matches.
/// </summary>
public class ProductSearchService
{
    private readonly List<string> _catalogue;

    public ProductSearchService(List<string> catalogue) => _catalogue = catalogue;

    public SearchResult Search(string term, int page, int pageSize)
    {
        var matches = _catalogue
            .Where(p => p.Contains(term, StringComparison.OrdinalIgnoreCase))
            .ToList();

        var items = matches
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToList();

        return new SearchResult(items, items.Count);
    }
}

public record SearchResult(IReadOnlyList<string> Items, int TotalMatches);

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
        // Paging is not implemented yet - see issue #7.
        return new SearchResult(new List<string>(), 0);
    }
}

public record SearchResult(IReadOnlyList<string> Items, int TotalMatches);

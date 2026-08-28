namespace Sandbox;

/// <summary>
/// Checks files submitted through the customer document upload form before they
/// are written to the shared uploads directory.
/// </summary>
public class FileUploadValidator
{
    public UploadResult Validate(string fileName, byte[] content)
    {
        // Nothing is checked yet - see issue #9.
        return new UploadResult(true, null);
    }
}

public record UploadResult(bool Accepted, string? Reason);

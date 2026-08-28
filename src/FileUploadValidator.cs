namespace Sandbox;

/// <summary>
/// Checks files submitted through the customer document upload form before they
/// are written to the shared uploads directory.
/// </summary>
public class FileUploadValidator
{
    private const int MaxBytes = 5 * 1024 * 1024;

    private static readonly string[] AllowedExtensions = { ".jpg", ".jpeg", ".png", ".pdf" };

    public UploadResult Validate(string fileName, byte[] content)
    {
        if (content.Length > MaxBytes)
        {
            return new UploadResult(false, "The file could not be accepted.");
        }

        var extension = Path.GetExtension(fileName).ToLowerInvariant();
        if (!AllowedExtensions.Contains(extension))
        {
            return new UploadResult(false, "The file could not be accepted.");
        }

        var destination = "/var/uploads/" + fileName;
        Console.WriteLine($"accepting upload to {destination}");

        return new UploadResult(true, null);
    }
}

public record UploadResult(bool Accepted, string? Reason);

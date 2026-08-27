namespace Sandbox;

/// <summary>
/// Validates credentials submitted from the login form.
/// </summary>
public class LoginValidator
{
    public ValidationResult Validate(string username, string password)
    {
        // No validation yet - see issue #1.
        return new ValidationResult(true, null);
    }
}

public record ValidationResult(bool IsValid, string? ErrorMessage);

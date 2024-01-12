using System.Text.RegularExpressions;

namespace Bookings.Domain.Users.ValueObjects;

public sealed class UserEmail : ValueObject
{
    public string Value { get; private init; }

    private static readonly Regex Regex =
        new("^[\\w!#$%&’*+/=?`{|}~^-]+(?:\\.[\\w!#$%&’*+/=?`{|}~^-]+)*@(?:[a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$",
            RegexOptions.Compiled | RegexOptions.IgnoreCase);

    private UserEmail(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentNullException("User email cannot be empty or white space", nameof(UserEmail));
        }

        if (!Regex.IsMatch(value))
        {
            throw new ArgumentException("User email is not a valid email address", nameof(UserEmail));
        }

        Value = value;
    }

    public UserEmail From(string value)
    {
        return new(value);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}

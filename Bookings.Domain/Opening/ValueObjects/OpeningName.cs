
namespace Bookings.Domain.Openings.ValueObjects;

public sealed class OpeningName : ValueObject
{
    public string Value { get; private init; }

    private OpeningName(string value)
    {
        if (string.IsNullOrWhiteSpace(Value))
        {
            throw new ArgumentException("Opening Name cannot be empty or white space", nameof(OpeningName));
        }

        if (Value.Length < 4)
        {
            throw new ArgumentException("Opening Name cannot have lenght less than 4", nameof(OpeningName));
        }

        Value = Value;
    }

    public OpeningName From(string value)
    {
        return new(value);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}


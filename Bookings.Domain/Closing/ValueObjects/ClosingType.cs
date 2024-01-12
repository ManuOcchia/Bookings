using Bookings.Domain.Closings.Enums;

namespace Bookings.Domain.Closings.ValueObjects;

public sealed class ClosingType : ValueObject
{
    public ClosingTypes Value { get; private init; }

    private ClosingType(int value)
    {
        if (!Enum.IsDefined(typeof(ClosingTypes), value))
        {
            throw new ArgumentOutOfRangeException(nameof(value), "Invalid ClosingTypes enum value");
        }

        Value = (ClosingTypes)value;
    }

    public ClosingType From(int value)
    {
        return new(value);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}


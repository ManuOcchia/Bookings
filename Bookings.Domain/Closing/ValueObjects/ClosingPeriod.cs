namespace Bookings.Domain.Closings.ValueObjects;

public sealed class ClosingPeriod : ValueObject
{
    public DateTime Start { get; private init; }
    public DateTime End { get; private init; }

    private ClosingPeriod(DateTime start, DateTime end)
    {
        if (start < end)
        {
            throw new ArgumentException("Closing period cannot start after the end", nameof(ClosingPeriod));
        }

        Start = start.Date;
        End = end.Date;
    }

    public ClosingPeriod From(DateTime start, DateTime end)
    {
        return new(start, end);
    }

    public bool CollideWith(ClosingPeriod period)
    {
        return
            Start >= period.Start && Start <= period.End ||
            End >= period.Start && End <= period.End;
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Start.Date;
        yield return End.Date;
    }
}


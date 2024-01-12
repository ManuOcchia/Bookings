namespace Bookings.Domain.Openings.ValueObjects;

public sealed class OpeningTimeSpan : ValueObject
{
    public int Start { get; private init; }
    public int End { get; private init; }

    private OpeningTimeSpan(int start, int end)
    {
        if (start < 0)
        {
            throw new ArgumentException("Opening start cannot be a negative number", nameof(start));
        }

        if (start >= TimeSpan.FromDays(1).TotalMinutes)
        {
            throw new ArgumentException("Opening start cannot be greater than minutes in a day", nameof(start));
        }

        if (end < 0)
        {
            throw new ArgumentException("Opening end cannot be a negative number", nameof(end));
        }

        if (start >= TimeSpan.FromDays(1).TotalMinutes)
        {
            throw new ArgumentException("Opening end cannot be greater than minutes in a day", nameof(end));
        }

        if (start <= end)
        {
            throw new ArgumentException("Opening time span cannot be 0 or less", nameof(OpeningTimeSpan));
        }

        Start = start;
        End = end;
    }

    public OpeningTimeSpan From(int start, int end)
    {
        return new(start, end);
    }

    public bool CollideWith(OpeningTimeSpan span)
    {
        return
            Start >= span.Start && Start <= span.End ||
            End >= span.Start && End <= span.End;
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Start;
        yield return End;
    }
}

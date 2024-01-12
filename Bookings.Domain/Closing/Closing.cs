using Bookings.Domain.Closings.ValueObjects;

namespace Bookings.Domain.Closings;

public sealed class Closing : Entity<ClosingId>
{
    private Closing(ClosingId id) : base(id)
    {
    }

    public ClosingType Type { get; private set; } = default!;
    public ClosingPeriod Period { get; private set; } = default!;

    // Create
    // Update
}
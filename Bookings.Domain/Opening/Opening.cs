using Bookings.Domain.Openings.ValueObjects;

namespace Bookings.Domain.Openings;

public sealed class Opening : Entity<OpeningId>
{
    private Opening(OpeningId id) : base(id)
    {
    }

    public OpeningName Name { get; private set; } = default!;
    public OpeningTimeSpan TimeSpan { get; private set; } = default!;


    // Create
    // Update
}
using Bookings.Domain.Closing.ValueObjects;

namespace Bookings.Domain.Closing;

public sealed class Closing : Entity<ClosingId>
{
    private Closing(ClosingId id) : base(id)
    {
    }

    // Create
    // Update
}
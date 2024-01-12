using Bookings.Domain.Opening.ValueObjects;

namespace Bookings.Domain.Opening;

public sealed class Opening : Entity<OpeningId>
{
    private Opening(OpeningId id) : base(id)
    {
    }

    // Create
    // Update
}
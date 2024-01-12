using Bookings.Domain.Reservations.ValueObjects;

namespace Bookings.Domain.Reservations;

public sealed class Reservation: Entity<ReservationId>
{
    private Reservation(ReservationId id) : base(id)
    {
    }

    public ReservationName Name { get; private set; } = default!;
    public ReservationPhone Phone { get; private set; } = default!;
    public ReservationPersons Persons { get; private set; } = default!;
    public ReservationDateTime DateTime { get; private set; } = default!;
    public ReservationState State { get; private set; } = default!;
    public ReservationNotes Notes { get; private set; } = default!;


    // Create
    // Update
}
using Bookings.Domain.Meals.ValueObjects;
using Bookings.Domain.Reservations;
using Bookings.Domain.Reservations.ValueObjects;

namespace Bookings.Domain.Meals;

public sealed class Meal : AggregateRoot<MealId>
{
    private Meal(MealId id) : base(id)
    {
    }

    public MealAvailability Availability { get; private set; } = default!;
    public Dictionary<ReservationId, Reservation> Bookings { get; private set; } = default!;

    // Add reservation
    // Update Reservation 
}
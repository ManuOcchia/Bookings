using Bookings.Domain.Closings;
using Bookings.Domain.Openings;
using Bookings.Domain.Restaurants.ValueObjects;

namespace Bookings.Domain.Restaurants;

public sealed class Restaurant : AggregateRoot<RestaurantId>
{
    private Restaurant(RestaurantId id) : base(id)
    {
    }

    public RestaurantName Name { get; private set; } = default!;
    public RestaurantSeats Seats { get; private set; } = default!;
    public RestaurantAddress Address { get; private set; } = default!;
    public List<Closing> Closings { get; private set; } = new();
    public List<Opening> Openings { get; private set; } = new();

    // Create
    // Update
    // Add Opening time
    // Update Opening time
    // Add Closing date/period
    // Remove Closing date/period
}
using Bookings.Domain.Restaurant.ValueObjects;

namespace Bookings.Domain.Restaurant;

public sealed class Restaurant : AggregateRoot<RestaurantId>
{
    private Restaurant(RestaurantId id) : base(id)
    {
    }
    public RestaurantName Name { get; private set; } = default!;
    public List<Closing> Closings { get; private set; } = new();
    public List<Openings> Openings { get; private set; } = new();

    // Create
    // Update
    // Add Opening time
    // Update Opening time
    // Add Closing
    // Remove Closing
}
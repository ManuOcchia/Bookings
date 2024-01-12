using Bookings.Domain.Restaurants;
using Bookings.Domain.Restaurants.ValueObjects;
using Bookings.Domain.Users.ValueObjects;

namespace Bookings.Domain.Users;

public sealed class User : AggregateRoot<UserId>
{
    private User(UserId id)
        : base(id)
    {
    }

    public UserEmail Email { get; private set; } = default!;
    public List<Restaurant> Restaurants { get; private set; } = new();

    // Create
    // Create Restaurant
    // Add Restaurant
    // Delete Restaurant
}
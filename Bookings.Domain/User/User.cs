using Bookings.Domain.Restaurant.ValueObjects;
using Bookings.Domain.User.ValueObjects;

namespace Bookings.Domain.User;

public sealed class User : AggregateRoot<UserId>
{
    private User(UserId id)
        : base(id)
    {
    }

    public UserEmail Email { get; private set; } = default!;
    public List<Restaurant> Restaurants { get; private set; } = new();

    // Create
    // AddRestaurant
    // DeleteRestaurant
}
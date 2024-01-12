namespace Bookings.Domain.Restaurants.ValueObjects;

public sealed class RestaurantId : EntityId
{
    private RestaurantId(Guid value)
        : base(value)
    {
    }

    public RestaurantId From(Guid value)
    {
        return new(value);
    }

    public static RestaurantId New()
    {
        return new RestaurantId(Guid.NewGuid());
    }
}

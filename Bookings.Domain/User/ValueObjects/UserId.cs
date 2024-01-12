namespace Bookings.Domain.Users.ValueObjects;

public sealed class UserId : EntityId
{
    private UserId(Guid value)
        : base(value)
    {
    }

    public UserId From(Guid value)
    {
        return new(value);
    }

    public static UserId New()
    {
        return new UserId(Guid.NewGuid());
    }
}

namespace Bookings.Domain.Meals.ValueObjects;

public sealed class MealId : EntityId
{
    private MealId(Guid value)
        : base(value)
    {
    }

    public MealId From(Guid value)
    {
        return new(value);
    }

    public static MealId New()
    {
        return new MealId(Guid.NewGuid());
    }
}

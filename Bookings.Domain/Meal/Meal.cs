using Bookings.Domain.Meal.ValueObjects;

namespace Bookings.Domain.User;

public sealed class Meal : AggregateRoot<MealId>
{
    private Meal(MealId id) : base(id)
    {
    }


    // Create
    // Update
    // Add Opening time
    // Update Opening time
    // Add Closing
    // Remove Closing
}
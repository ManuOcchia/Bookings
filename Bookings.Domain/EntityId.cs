namespace Bookings.Domain;

public abstract class EntityId : ValueObject
{
    public Guid Value { get; private init; }

    protected EntityId(Guid value)
    {
        if (value == Guid.Empty)
        {
            throw new ArgumentException($"{GetType().Name} cannot have an empty Guid", nameof(EntityId));
        }

        Value = value;
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}

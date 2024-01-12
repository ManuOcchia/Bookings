namespace Bookings.Domain;

public abstract class AggregateRoot<TId> : Entity<TId> where TId : EntityId
{
    protected AggregateRoot(TId id) : base(id)
    {
    }

    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string? ToString()
    {
        return base.ToString();
    }
}

namespace Ordering.Domain;

public interface IIdentifier<T>
{
    public T Id { get; set; }
}
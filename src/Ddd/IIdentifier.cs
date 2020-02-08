namespace Basje.Ddd
{
    public interface IIdentifier<T> : IValueObject
    {
        public T Value { get; }
    }
}
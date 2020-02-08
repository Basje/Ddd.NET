using System;

namespace Basje.Ddd
{
    public interface IValueObject : IEquatable<IValueObject>
    {
        public bool EqualsValueOf(IValueObject valueObject);
    }
}
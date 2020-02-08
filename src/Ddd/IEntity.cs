using System;

namespace Basje.Ddd
{
    public interface IEntity<TId> : IEquatable<IIdentifier<TId>> where TId : struct
    {
        public IIdentifier<TId> Id { get; }

        public bool EqualsIdentityOf(IEntity<TId> entity);
    }
}
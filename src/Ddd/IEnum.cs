using System.Collections.Generic;

namespace Basje.Ddd
{
    public interface IEnum<T>
    {
        public IEnumerable<string> Keys { get; }
        public IEnumerable<T> Values { get; }
    }
}
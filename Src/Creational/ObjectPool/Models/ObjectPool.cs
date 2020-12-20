using System;
using System.Collections.Concurrent;

namespace ObjectPool.Models
{
    public class ObjectPool<T>
    {
        private ConcurrentBag<T> _objects = new ConcurrentBag<T>();
        private Func<T> _objectGenerator;

        public ObjectPool(Func<T> objectGenerator)
        {
            _objectGenerator = objectGenerator ?? throw new ArgumentNullException("objectGenerator");
        }

        public T Get()
        {
            if (_objects.TryTake(out T item)) return item;
            return _objectGenerator();
        }

        public void Release(T item)
        {
            _objects.Add(item);
        }

    }
}

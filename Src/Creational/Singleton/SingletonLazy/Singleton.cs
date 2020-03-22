using System;

namespace Singleton.SingletonLazy
{
    public sealed class Singleton
    {
        private static readonly Lazy<Singleton> Lazy = new Lazy<Singleton>(() => new Singleton());

        private Singleton()
        {

        }
        public static Singleton Instance => Lazy.Value;
    }
}

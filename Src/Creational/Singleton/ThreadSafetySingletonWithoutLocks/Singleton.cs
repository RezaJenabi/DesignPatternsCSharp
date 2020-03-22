namespace Singleton.ThreadSafetySingletonWithoutLocks
{
    public sealed class Singleton
    {
        private static readonly Singleton _instance = new Singleton();

        private Singleton()
        {

        }

        static Singleton()
        {
        }

        public static Singleton Instance => _instance;
    }
}

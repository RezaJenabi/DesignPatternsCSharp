namespace Singleton.NoThreadSafeSingleton
{
    public sealed class Singleton
    {
        private static Singleton _instance = null;

        private Singleton()
        {

        }

        public static Singleton Instance => _instance ?? (_instance = new Singleton());
    }
}

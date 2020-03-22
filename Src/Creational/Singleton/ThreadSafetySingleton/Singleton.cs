namespace Singleton.ThreadSafetySingleton
{
    public sealed class Singleton
    {
        private static Singleton _instance = null;
        private static readonly object Padlock = new object();

        private Singleton()
        {

        }

        public static Singleton Instance
        {
            get
            {
                lock (Padlock)
                {
                    return _instance ?? (_instance = new Singleton());
                }
            }
        }
    }
}

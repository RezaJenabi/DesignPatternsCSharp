namespace Singleton.ThreadSafetySingletonDoubleCheckLocking
{
    public sealed class Singleton
    {
        private static Singleton _instance = null;
        private static readonly object padlock = new object();

        private Singleton()
        {

        }

        public static Singleton Instance
        {
            get
            {
                if (_instance != null) return _instance;
                lock (padlock)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                }
                return _instance;
            }
        }
    }
}

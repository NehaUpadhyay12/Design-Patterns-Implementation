using System;

namespace SingletonDP
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Singleton S1 = Singleton.Instance;
            Singleton S2 = Singleton.Instance;

            Console.WriteLine(S1 == S2);
        }
    }

    public class Singleton
    {
        private static Singleton _instance = null;
        private static readonly object obj = new object();
        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                if(_instance == null)
                {
                    lock (obj)
                    {
                        if (_instance == null)
                             _instance = new Singleton();
                    }
                }
                return _instance;
            }
        }
    }
}

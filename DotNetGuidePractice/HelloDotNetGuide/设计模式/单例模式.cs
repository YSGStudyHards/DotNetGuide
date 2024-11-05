namespace HelloDotNetGuide.设计模式
{
    public class 单例模式
    {
        /// <summary>
        /// 饿汉式单例模式
        /// </summary>
        public class SingletonEager
        {
            private SingletonEager() { }

            private static readonly SingletonEager _instance = new SingletonEager();

            public static SingletonEager Instance
            {
                get { return _instance; }
            }

            public void DoSomething()
            {
                Console.WriteLine("饿汉式单例模式.");
            }
        }

        /// <summary>
        /// 懒汉式单例模式
        /// </summary>
        public class SingletonLazy
        {
            private SingletonLazy() { }

            private static SingletonLazy? _instance;

            private static readonly object _lockObj = new object();

            public static SingletonLazy Instance
            {
                get
                {
                    if (_instance == null)
                    {
                        lock (_lockObj)
                        {
                            if (_instance == null)
                            {
                                _instance = new SingletonLazy();
                            }
                        }
                    }
                    return _instance;
                }
            }

            public void DoSomething()
            {
                Console.WriteLine("懒汉式单例模式.");
            }
        }

        /// <summary>
        /// 懒加载单例模式
        /// </summary>
        public sealed class SingletonByLazy
        {
            private static readonly Lazy<SingletonByLazy> _lazy = new Lazy<SingletonByLazy>(() => new SingletonByLazy());

            public static SingletonByLazy Instance { get { return _lazy.Value; } }

            private SingletonByLazy() { }

            public void DoSomething()
            {
                Console.WriteLine("懒加载单例模式.");
            }
        }
    }
}

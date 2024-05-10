namespace HelloDotNetGuide.异步多线程编程
{
    /// <summary>
    /// C#实现多线程的四种方式
    /// </summary>
    public class MultithreadingExample
    {
        /// <summary>
        /// 使用 Thread 类
        /// </summary>
        public static void ThreadMethod()
        {
            var newThread = new Thread(WorkerMethod);
            newThread.Start();

            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine($"ThreadMethod 主线程开始工作：{i}");
                Thread.Sleep(100);
            }
        }

        /// <summary>
        /// 使用 ThreadPool 类
        /// </summary>
        public static void ThreadPoolMethod()
        {
            ThreadPool.QueueUserWorkItem(o => WorkerMethod());

            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine($"ThreadPoolMethod 主线程开始工作：{i}");
                Thread.Sleep(100);
            }
        }

        /// <summary>
        /// 使用 Task 类
        /// </summary>
        public static void TaskMethod()
        {
            Task.Run(() => WorkerMethod());

            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine($"TaskMethod 主线程开始工作：{i}");
                Task.Delay(100).Wait();
            }
        }

        /// <summary>
        /// 使用 Parallel 类
        /// </summary>
        public static void ParallelMethod()
        {
            Parallel.Invoke(WorkerMethod, WorkerMethodOther1, WorkerMethodOther2);
        }

        private static void WorkerMethod()
        {
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine($"WorkerMethod 辅助线程开始工作：{i}");
                Thread.Sleep(100);
            }
        }

        private static void WorkerMethodOther1()
        {
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine($"WorkerMethodOther1 辅助线程开始工作：{i}");
                Thread.Sleep(100);
            }
        }

        private static void WorkerMethodOther2()
        {
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine($"WorkerMethodOther2 辅助线程开始工作：{i}");
                Thread.Sleep(100);
            }
        }
    }
}

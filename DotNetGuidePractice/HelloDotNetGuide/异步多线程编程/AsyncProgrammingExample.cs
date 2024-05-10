using System.ComponentModel;

namespace HelloDotNetGuide.异步多线程编程
{
    /// <summary>
    /// .NET异步实现的四种方式
    /// </summary>
    public class AsyncProgrammingExample
    {
        #region TAP模式

        /// <summary>
        /// 异步方法（Async Method TAP模式）
        /// </summary>
        /// <returns></returns>
        public static async Task TestDoSomeAsync()
        {
            await Task.Delay(1000 * 10).ConfigureAwait(false); //等待10秒
            Console.WriteLine("Async Method Completed.");
        }

        /// <summary>
        /// 任务并行库（TPL, Task Parallel Library TAP模式）
        /// </summary>
        public static void TestTaskParallel()
        {
            var task1 = Task.Run(() =>
            {
                Console.WriteLine("Task 1 Completed.");
            });

            var task2 = Task.Run(() =>
            {
                Console.WriteLine("Task 2 Completed.");
            });

            Task<int> task3 = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Task 3 Completed.");
                return 20; // 返回一个整数值
            });

            //等待所有任务完成
            Task.WaitAll(task1, task2, task3);
        }

        #endregion

        #region  APM模式

        //注意：在 .NET Core 或 .NET 5+ 等新版本中，BeginInvoke 方法已经被弃用并不再支持，因此可能会导致 System.PlatformNotSupportedException 异常，不过在.NET FX环境是支持的。

        /// <summary>
        /// Asynchronous Programming Model（APM模式）
        /// </summary>
        public static void TestAPMAsync()
        {
            // 创建一个 AsyncCallback 委托，用于处理异步操作完成后的回调
            var callback = new AsyncCallback(AsyncOperationCallback);

            // 创建一个异步委托实例，表示要异步执行的操作
            var asyncMethod = new Func<int, string>(AsyncMethod);

            // 开始异步操作
            var result = asyncMethod.BeginInvoke(88, callback, asyncMethod);

            Console.WriteLine($"TestAPMAsync Completed.");
            Console.ReadLine();
        }

        private static string AsyncMethod(int parameter)
        {
            Console.WriteLine("AsyncMethod开始执行了...");
            return $"异步操作完成，参数为：{parameter}。";
        }

        private static void AsyncOperationCallback(IAsyncResult result)
        {
            try
            {
                // 从异步状态对象中获取返回的异步委托
                Func<int, string> asyncMethod = (Func<int, string>)result.AsyncState;
                string message = asyncMethod.EndInvoke(result);
                Console.WriteLine(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"异步操作发生异常：{ex.Message}");
            }
        }

        #endregion

        #region EAP模式

        /// <summary>
        /// Event-based Asynchronous Pattern（EAP模式）
        /// </summary>
        public static void TestEAPAsync()
        {
            var asyncObj = new MyAsyncClass();

            // 订阅异步操作完成事件
            asyncObj.OperationNameCompleted += AsyncObjOperationNameCompleted;

            // 启动异步操作
            asyncObj.DoWorkAsync(10);

            Console.ReadLine();
        }

        /// <summary>
        /// 异步操作完成事件的处理方法
        /// </summary>
        /// <param name="result">result</param>
        private static void AsyncObjOperationNameCompleted(int result)
        {
            Console.WriteLine($"异步操作完成，结果为: {result}");
        }

        #endregion
    }

    public class MyAsyncClass : Component
    {
        /// <summary>
        /// 声明一个委托类型，用于定义异步操作的方法签名
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        public delegate void MyAsyncDelegate(int arg);

        /// <summary>
        /// 声明一个事件，用于通知异步操作的完成
        /// </summary>
        public event MyAsyncDelegate OperationNameCompleted;

        /// <summary>
        /// 异步执行方法，接受一个参数 arg
        /// </summary>
        /// <param name="arg"></param>
        public void DoWorkAsync(int arg)
        {
            // 将异步操作放入线程池中执行
            ThreadPool.QueueUserWorkItem(new WaitCallback(DoWork), arg);
        }

        /// <summary>
        /// 真正的异步操作
        /// </summary>
        /// <param name="obj"></param>
        private void DoWork(object obj)
        {
            int arg = (int)obj;
            int res = arg + 1;

            // 触发事件，传递异步操作的结果
            OperationNameCompleted?.Invoke(res);
        }
    }
}

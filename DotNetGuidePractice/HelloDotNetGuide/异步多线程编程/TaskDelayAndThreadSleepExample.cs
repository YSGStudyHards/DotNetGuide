using System.Diagnostics;

namespace HelloDotNetGuide.异步多线程编程
{
    public class TaskDelayDemo
    {
        public async Task RunAsynchronousWorkAsync()
        {
            Console.WriteLine($"[线程 {Thread.CurrentThread.ManagedThreadId}] 开始异步工作...");
            Stopwatch sw = Stopwatch.StartNew();

            // 释放当前线程：3秒后，状态机恢复，可能会由同一个线程或另一个空闲线程继续执行
            await Task.Delay(3000);

            Console.WriteLine($"[线程 {Thread.CurrentThread.ManagedThreadId}] 异步工作完成，耗时: {sw.ElapsedMilliseconds}ms");
        }

        public async Task RunWithCancellationAsync(CancellationToken token)
        {
            try
            {
                // 高级用法：支持取消的延迟
                Console.WriteLine("准备延迟 10 秒...");
                // 如果在 10 秒内 token 被取消，这里会抛出 TaskCanceledException
                await Task.Delay(10000, token);
                Console.WriteLine("延迟正常结束");
            }
            catch (TaskCanceledException)
            {
                Console.WriteLine("延迟被提前取消了！");
            }
        }
    }

    public class ThreadSleepDemo
    {
        public void RunSynchronousWork()
        {
            Console.WriteLine($"[线程 {Thread.CurrentThread.ManagedThreadId}] 开始同步工作...");
            Stopwatch sw = Stopwatch.StartNew();

            // 此时，当前线程被彻底冻结，无法响应任何其他事件
            Thread.Sleep(3000);

            Console.WriteLine($"[线程 {Thread.CurrentThread.ManagedThreadId}] 同步工作完成，耗时: {sw.ElapsedMilliseconds}ms");
        }
    }
}

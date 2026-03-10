using System.Diagnostics;

namespace HelloDotNetGuide.异步多线程编程
{
    public class TaskWhenAllAndTaskWhenAnyExample
    {
        #region 并发执行多个任务等待全部完成

        public static async Task TaskWhenAllExample()
        {
            var sw = Stopwatch.StartNew();

            Task task1 = DoWorkAsync("任务A", 2000);
            Task task2 = DoWorkAsync("任务B", 3000);
            Task task3 = DoWorkAsync("任务C", 1000);

            await Task.WhenAll(task1, task2, task3);

            sw.Stop();
            Console.WriteLine($"全部完成，总耗时：{sw.ElapsedMilliseconds} ms");
            //三个任务几乎同时开始
            //总耗时约等于 最长的那个任务
            //不是 2000 + 3000 + 1000，而是接近 3000ms
        }

        private static async Task DoWorkAsync(string name, int delay)
        {
            Console.WriteLine($"{name} 开始，耗时 {delay} ms");
            await Task.Delay(delay);
            Console.WriteLine($"{name} 完成");
        }

        #endregion

        #region 谁先完成就先处理谁

        public static async Task TaskWhenAnyExample()
        {
            Task<string> task1 = GetDataAsync("接口A", 3000);
            Task<string> task2 = GetDataAsync("接口B", 1000);
            Task<string> task3 = GetDataAsync("接口C", 2000);

            Task<string> completedTask = await Task.WhenAny(task1, task2, task3);
            string result = await completedTask;

            Console.WriteLine($"最先返回的结果：{result}");
            //最先完成的是:接口B
        }

        private static async Task<string> GetDataAsync(string source, int delay)
        {
            await Task.Delay(delay);
            return $"{source} 返回成功";
        }

        #endregion
    }
}

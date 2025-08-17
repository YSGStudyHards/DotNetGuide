using System.Diagnostics;

namespace HelloDotNetGuide.异步多线程编程
{
    public class ParallelExample
    {
        public static void ParallelForExample()
        {
            var length = 1000000;
            var stopwatch = Stopwatch.StartNew();

            // 统计普通 for 循环耗时
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < 1000; j++)
                {
                    var sum = i * j;
                }
            }
            stopwatch.Stop();
            Console.WriteLine($"普通 for 循环耗时: {stopwatch.ElapsedMilliseconds} 毫秒");

            stopwatch.Restart();

            // 统计 Parallel.For 循环耗时
            Parallel.For(0, length, i =>
            {
                for (int j = 0; j < 1000; j++)
                {
                    var sum = i * j;
                }
            });

            stopwatch.Stop();
            Console.WriteLine($"Parallel.For 循环耗时: {stopwatch.ElapsedMilliseconds} 毫秒");
            Console.ReadKey();
        }

        public static void ParallelForEachExample()
        {
            var length = 1000000;
            var numbers = Enumerable.Range(0, length).ToList();

            var stopwatch = Stopwatch.StartNew();

            // 统计普通 foreach 循环耗时
            foreach (var i in numbers)
            {
                for (int j = 0; j < 1000; j++)
                {
                    var sum = i * j;
                }
            }
            stopwatch.Stop();
            Console.WriteLine($"普通 foreach 循环耗时: {stopwatch.ElapsedMilliseconds} 毫秒");

            stopwatch.Restart();

            // 统计 Parallel.ForEach 循环耗时
            Parallel.ForEach(numbers, i =>
            {
                for (int j = 0; j < 1000; j++)
                {
                    var sum = i * j;
                }
            });

            stopwatch.Stop();
            Console.WriteLine($"Parallel.ForEach 循环耗时: {stopwatch.ElapsedMilliseconds} 毫秒");
            Console.ReadKey();
        }

        public static void ParallelForCounterexample()
        {
            object lockObj = new object();

            var stopwatch = Stopwatch.StartNew();
            long sumFor = 0;
            for (int i = 0; i < 1000; i++)
            {
                sumFor += i; // 简单累加
            }
            stopwatch.Stop();
            Console.WriteLine($"普通 for 循环: 结果 = {sumFor}, 耗时 = {stopwatch.ElapsedMilliseconds} 毫秒");


            stopwatch.Restart();

            long sumParallel = 0;
            Parallel.For(0, 1000, i =>
            {
                // 因为多个线程同时修改同一个变量会导致计算结果丢失，lock 能确保每次只有一个线程可以修改，保证结果正确。
                lock (lockObj)
                {
                    sumParallel += i;
                }
            });

            stopwatch.Stop();
            Console.WriteLine($"Parallel.For: 结果 = {sumParallel}, 耗时 = {stopwatch.ElapsedMilliseconds} 毫秒");

            Console.ReadKey();
        }
    }
}

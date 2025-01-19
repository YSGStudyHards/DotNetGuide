namespace HelloDotNetGuide.CSharp语法
{
    public class YieldExercise
    {
        #region 传统迭代方式和yield关键字迭代方式对比

        /// <summary>
        /// 传统迭代方式和yield关键字迭代方式对比
        /// </summary>
        public static void IteratorComparisonRun()
        {
            Console.WriteLine("迭代器方法使用yield关键字:");
            foreach (var number in GetNumbersWithYield())
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("传统迭代方法返回一个List<int>");
            var numbers = GetNumbersWithoutYield();
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        /// <summary>
        /// 迭代器方法使用yield关键字
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<int> GetNumbersWithYield()
        {
            for (int i = 0; i < 6; i++)
            {
                yield return i;
            }
        }

        /// <summary>
        /// 传统迭代方法返回一个List<int>
        /// </summary>
        /// <returns></returns>
        public static List<int> GetNumbersWithoutYield()
        {
            var numbers = new List<int>();
            for (int i = 0; i < 6; i++)
            {
                numbers.Add(i);
            }
            return numbers;
        }

        #endregion

        #region yield关键字延迟加载按需获取数据

        /// <summary>
        /// yield关键字延迟加载按需获取数据
        /// </summary>
        public static void LazyLoadingRun()
        {
            Console.WriteLine("yield延迟加载按需获取数据 开始...");

            foreach (var number in GetEvenNumbers(11))
            {
                Console.WriteLine($"返回值 === {number} ===");
                Thread.Sleep(500);
            }

            Console.WriteLine("yield延迟加载按需获取数据 结束...");
        }

        /// <summary>
        /// 使用yield返回偶数的迭代器方法
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<int> GetEvenNumbers(int number)
        {
            for (int i = 1; i < number; i++)
            {
                Console.WriteLine($"Yielding {i}");
                if (i % 2 == 0)
                {
                    yield return i; //只在需要时生成偶数
                }
            }
        }

        #endregion

        #region yield break显式示迭代结束

        public static void YieldBreakRun()
        {
            Console.WriteLine(string.Join(" ", TakeWhilePositive(new int[] { 1, 3, 4, 5, -1, 3, 4 })));
            //输出：1 3 4 5

            Console.WriteLine(string.Join(" ", TakeWhilePositive(new int[] { 9, 8, 7, 6, 5, -5, 88, 100 })));
            //输出：9 8 7 6 5
        }

        public static IEnumerable<int> TakeWhilePositive(IEnumerable<int> numbers)
        {
            foreach (int n in numbers)
            {
                if (n > 0)
                {
                    yield return n;
                }
                else
                {
                    yield break;
                }
            }
        }

        #endregion
    }
}

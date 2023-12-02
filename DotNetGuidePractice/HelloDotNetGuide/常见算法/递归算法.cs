namespace HelloDotNetGuide.常见算法
{
    public class 递归算法
    {
        #region 使用C#语言编写的递归算法来计算1+2+3+4+…+100的结果

        /// <summary>
        /// 使用C#语言编写的递归算法来计算1+2+3+4+…+100的结果
        /// 最终输出结果是：5050
        /// </summary>
        public static void RecursiveAlgorithmSum()
        {
            int result = SumNumbers(100);
            Console.WriteLine("1+2+3+4+...+100 = " + result);
        }

        public static int SumNumbers(int n)
        {
            if (n == 1)
            {
                return 1;//递归结束条件
            }
            else
            {
                return n + SumNumbers(n - 1);
            }
        }

        #endregion

        #region 一列数的规则如下 : 1 、 1 、 2 、 3 、 5 、 8 、 13 、 21 、 34… 求第 30 位数是多少， 用递归算法实现

        /// <summary>
        /// 使用递归算法来实现求解斐波纳契数列中第30位数的值
        /// 最终输出结果为：832040
        /// </summary>
        public static void FibonacciSum()
        {
            int n = 30;
            int result = Fibonacci(n);
            Console.WriteLine("第 " + n + "位斐波那契数是：" + result);
        }

        public static int Fibonacci(int n)
        {
            if (n <= 0)
            {
                return 0;
            }
            else if (n > 0 && n <= 2)
            {
                return 1;
            }
            else
            {
                // 递归情况：调用自身计算前两个数字之和
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }

        #endregion

        #region 递归算法数组求

        /// <summary>
        /// 递归算法数组求
        /// 最终输出结果为：259
        /// </summary>
        public static void RecursiveArraySum()
        {
            int[] numbers = { 1, 88, 66, 4, 100 };
            int sum = ArraySum(numbers, 0);
            Console.WriteLine("数组元素的总和为：" + sum);
        }

        /// <summary>
        /// 计算数组元素的总和
        /// </summary>
        /// <param name="arr">arr</param>
        /// <param name="index">index</param>
        /// <returns></returns>
        public static int ArraySum(int[] arr, int index)
        {
            if (index >= arr.Length)
            {
                // 基本情况：数组为空或者已经遍历完所有元素
                return 0;
            }
            else
            {
                // 递归调用：当前元素加上剩余元素的总和
                return arr[index] + ArraySum(arr, index + 1);
            }
        }

        #endregion
    }
}

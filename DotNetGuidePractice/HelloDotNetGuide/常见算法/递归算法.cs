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

        #region C#使用递归算法来实现求解斐波纳契数列中第30位数的值

        /// <summary>
        /// 使用递归算法来实现求解斐波纳契数列中第30位数的值
        /// 一列数的规则如下 : 1 、 1 、 2 、 3 、 5 、 8 、 13 、 21 、 34… 求第 30 位数是多少， 用递归算法实现
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

        #region C#递归算法数组求

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

        #region C#递归算法计算阶乘的方法

        /// <summary>
        /// C#递归算法计算阶乘的方法
        /// 一个正整数的阶乘（factorial）是所有小于及等于该数的正整数的积，并且0的阶乘为1。自然数n的阶乘写作n!。1808年，基斯顿·卡曼引进这个表示法。
        /// 亦即n!=1×2×3×...×(n-1)×n。阶乘亦可以递归方式定义：0!=1，n!=(n-1)!×n。
        /// </summary>
        public static void RecursiveFactorial()
        {
            int result = Factorial(5);
            Console.WriteLine("5的阶乘为：" + result);//5!=120
        }

        public static int Factorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                // 递归调用：当前数n乘以前面所有数的阶乘
                return n * Factorial(n - 1);
            }
        }

        #endregion
    }
}

namespace HelloDotNetGuide.常见算法
{
    public class 递归算法
    {
        #region 使用C#语言编写的递归算法来计算1+2+3+4+…+100的结果

        /// <summary>
        /// 使用C#语言编写的递归算法来计算1+2+3+4+…+100的结果
        /// 最终结果是：5050
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
        /// 最终结果为832040
        /// </summary>
        public static void FibonacciSum()
        {
            int result = Fibonacci(30);
            Console.WriteLine("第30位斐波那契数是：" + result);
        }

        public static int Fibonacci(int n)
        {
            if (n <= 2)
            {
                return 1;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }

        #endregion
    }
}

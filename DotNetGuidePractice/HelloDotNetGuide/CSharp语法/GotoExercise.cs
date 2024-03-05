namespace HelloDotNetGuide.CSharp语法
{
    public class GotoExercise
    {
        /// <summary>
        /// 使用goto进行代码重试示例
        /// </summary>
        public static void GotoRetryUseExample()
        {
            int retryCount = 0;
            for (int i = 0; i < 10; i++)
            {
            retryLogic:
                try
                {
                    //模拟可能出错的操作
                    Random random = new Random();
                    int result = random.Next(0, 2);

                    if (result == 0)
                    {
                        throw new Exception("Error occurred");
                    }

                    Console.WriteLine("Operation successful on attempt: " + retryCount);
                }
                catch (Exception ex)
                {
                    retryCount++;
                    if (retryCount < 3)
                    {
                        Console.WriteLine("Error occurred, retrying...");
                        goto retryLogic; //跳转到重试逻辑
                    }
                    else
                    {
                        Console.WriteLine("Max retry limit reached.");
                        return;
                    }
                }
            }
        }

        /// <summary>
        /// 不使用goto进行代码重试示例
        /// </summary>
        public static void NonGotoRetryUseExample()
        {
            int retryCount = 0;
            for (int i = 0; i < 10; i++)
            {
                while (retryCount < 3)
                {
                    try
                    {
                        //模拟可能出错的操作
                        Random random = new Random();
                        int result = random.Next(0, 2);

                        if (result == 0)
                        {
                            throw new Exception("Error occurred");
                        }

                        Console.WriteLine("Operation successful on attempt: " + retryCount);
                        break;
                    }
                    catch (Exception ex)
                    {
                        retryCount++;
                        Console.WriteLine("Error occurred, retrying...");
                    }
                }

                if (retryCount == 3)
                {
                    Console.WriteLine("Max retry limit reached.");
                    return;
                }
            }
        }

        /// <summary>
        /// goto正常输出使用示例
        /// </summary>
        public static void GotoGeneralUseExample(int num)
        {
            if (num < 0)
            {
                goto LessThanZero;
            }
            else if (num == 0)
            {
                goto EqualToZero;
            }
            else
            {
                goto GreaterThanZero;
            }

        LessThanZero:
            Console.WriteLine("数字小于零");
            goto End;

        EqualToZero:
            Console.WriteLine("数字等于零");
            goto End;

        GreaterThanZero:
            Console.WriteLine("数字大于零");
            goto End;
        End:
            Console.WriteLine("End...");
        }

        /// <summary>
        /// 不使用goto正常输出使用示例
        /// </summary>
        public static void NonGotoGeneralUseExample(int num)
        {
            if (num < 0)
            {
                Console.WriteLine("数字小于零");
            }
            else if (num == 0)
            {
                Console.WriteLine("数字等于零");
            }
            else
            {
                Console.WriteLine("数字大于零");
            }
            Console.WriteLine("End...");
        }
    }
}

namespace HelloDotNetGuide.常见算法
{
    public class 冒泡排序算法
    {
        /// <summary>
        /// 双重循环方式实现冒泡排序
        /// </summary>
        public static void BubbleSort()
        {
            int[] arr = { 1, 8, 9, 5, 6, 2, 3, 4, 7 };
            int arrLength = arr.Length;
            for (int i = 0; i < arrLength - 1; i++)
            {
                for (int j = 0; j < arrLength - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        //交换arr[j]和arr[j+1]的值
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("排序后结果：" + string.Join(", ", arr));
        }

        /// <summary>
        /// 递归方式实现冒泡排序
        /// </summary>
        /// <param name="arr">arr</param>
        /// <param name="arrLength">arrLength</param>
        public static void RecursiveBubbleSort(int[] arr, int arrLength)
        {
            if (arrLength == 1)
                return;

            for (int i = 0; i < arrLength - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    //交换arr[i]和arr[i+1]的值
                    int temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                }
            }

            RecursiveBubbleSort(arr, arrLength - 1);
        }

        public static void RecursiveBubbleSortRun()
        {
            int[] arr = { 1, 8, 9, 5, 6, 2, 3, 4, 7 };
            int arrLength = arr.Length;
            RecursiveBubbleSort(arr, arrLength);
            Console.WriteLine("排序后结果：" + string.Join(", ", arr));
        }
    }
}

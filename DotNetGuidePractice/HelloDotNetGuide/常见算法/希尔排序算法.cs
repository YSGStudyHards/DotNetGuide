namespace HelloDotNetGuide.常见算法
{
    public class 希尔排序算法
    {
        public static void ShellSort(int[] array)
        {
            int arrLength = array.Length;

            // 初始化增量（初始间隔）为数组长度的一半
            int gap = arrLength / 2;

            // 不断缩小增量，直到增量为1
            while (gap > 0)
            {
                // 对每个子序列进行插入排序
                for (int i = gap; i < arrLength; i++)
                {
                    int temp = array[i];
                    int j = i;

                    // 在子序列内部进行插入排序
                    while (j >= gap && array[j - gap] > temp)
                    {
                        array[j] = array[j - gap];
                        j -= gap;
                    }

                    array[j] = temp;
                }

                // 缩小增量
                gap /= 2;
            }
        }

        public static void ShellSortRun()
        {
            int[] array = { 19, 20, 22, 32, 34, 50, 99, 49, 1, 11, 11, 55, 35, 93, 96, 71, 70, 38, 78, 48 };

            Console.WriteLine("排序前数组：" + string.Join(", ", array));

            ShellSort(array);

            Console.WriteLine("排序后数组：" + string.Join(", ", array));
        }
    }
}

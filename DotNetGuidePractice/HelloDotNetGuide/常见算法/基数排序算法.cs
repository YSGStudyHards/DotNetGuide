namespace HelloDotNetGuide.常见算法
{
    public class 基数排序算法
    {
        public static void RadixSort(int[] array)
        {
            if (array == null || array.Length < 2)
            {
                return;
            }

            //获取数组中的最大值，确定排序的位数
            int max = GetMaxValue(array);

            //进行基数排序
            for (int exp = 1; max / exp > 0; exp *= 10)
            {
                CountingSort(array, exp);
            }
        }

        private static void CountingSort(int[] array, int exp)
        {
            int arrayLength = array.Length;
            int[] output = new int[arrayLength];
            int[] count = new int[10];

            //统计每个桶中的元素个数
            for (int i = 0; i < arrayLength; i++)
            {
                count[(array[i] / exp) % 10]++;
            }

            //计算每个桶中最后一个元素的位置
            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }

            //从原数组中取出元素，放入到输出数组中
            for (int i = arrayLength - 1; i >= 0; i--)
            {
                output[count[(array[i] / exp) % 10] - 1] = array[i];
                count[(array[i] / exp) % 10]--;
            }

            //将输出数组复制回原数组
            for (int i = 0; i < arrayLength; i++)
            {
                array[i] = output[i];
            }
        }

        private static int GetMaxValue(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        public static void RadixSortRun()
        {
            int[] array = { 19, 27, 46, 48, 99, 888, 50, 2, 4, 44, 47, 36, 38, 15, 26, 5, 3 };

            Console.WriteLine("排序前数组：" + string.Join(", ", array));

            RadixSort(array);

            Console.WriteLine("排序后数组：" + string.Join(", ", array));
        }
    }
}

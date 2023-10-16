namespace HelloDotNetGuide.常见算法
{
    public class 计数排序算法
    {
        public static void CountingSort(int[] array)
        {
            int arrayLength = array.Length;
            if (arrayLength <= 1) return;

            int min = array[0];
            int max = array[0];

            //找出最大值和最小值
            for (int i = 1; i < arrayLength; i++)
            {
                if (array[i] < min) min = array[i];
                if (array[i] > max) max = array[i];
            }

            //统计每个元素出现的次数
            int[] count = new int[max - min + 1];

            //统计每个元素出现的次数
            for (int i = 0; i < arrayLength; i++)
            {
                count[array[i] - min]++;
            }

            //根据count数组和min值确定每个元素的起始位置
            for (int i = 1; i < count.Length; i++)
            {
                count[i] += count[i - 1];
            }

            //存储排序结果
            int[] temp = new int[arrayLength];

            //根据count数组和min值确定每个元素在temp数组中的位置
            for (int i = arrayLength - 1; i >= 0; i--)
            {
                int index = count[array[i] - min] - 1;
                temp[index] = array[i];
                count[array[i] - min]--;
            }

            //将排序结果复制回原数组
            for (int i = 0; i < arrayLength; i++)
            {
                array[i] = temp[i];
            }
        }

        public static void CountingSortRun()
        {
            int[] array = { 19, 27, 46, 48, 50, 2, 4, 44, 47, 36, 38, 15, 26, 5, 3, 99, 888 };

            Console.WriteLine("排序前数组：" + string.Join(", ", array));

            CountingSort(array);

            Console.WriteLine("排序后数组：" + string.Join(", ", array));
        }
    }
}

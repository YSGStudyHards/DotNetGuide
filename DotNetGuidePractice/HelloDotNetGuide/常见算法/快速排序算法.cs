namespace HelloDotNetGuide.常见算法
{
    public class 快速排序算法
    {
        public static void Sort(int[] array, int low, int high)
        {
            if (low < high)
            {
                //将数组分割为两部分，并返回分割点的索引
                int pivotIndex = Partition(array, low, high);

                //递归对分割后的两部分进行排序
                Sort(array, low, pivotIndex - 1);
                Sort(array, pivotIndex + 1, high);
            }
        }

        private static int Partition(int[] array, int low, int high)
        {
            //选择最后一个元素作为基准元素
            int pivot = array[high];
            int i = low - 1;

            for (int j = low; j <= high - 1; j++)
            {
                //如果当前元素小于等于基准元素，则将它与i+1位置的元素交换
                if (array[j] <= pivot)
                {
                    i++;
                    Swap(array, i, j);
                }
            }

            //将基准元素放置到正确的位置上
            Swap(array, i + 1, high);

            return i + 1; //返回基准元素的索引
        }

        private static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        public static void QuickSortRun()
        {
            int[] array = { 2, 3, 5, 38, 19, 15, 26, 27, 36, 44, 47, 46, 50, 48, 4 };
            Sort(array, 0, array.Length - 1);
            Console.WriteLine("排序后结果：" + string.Join(", ", array));
        }
    }
}

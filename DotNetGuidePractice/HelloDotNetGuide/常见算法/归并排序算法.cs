namespace HelloDotNetGuide.常见算法
{
    public class 归并排序算法
    {
        public static void MergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                // 计算中间索引
                int mid = (left + right) / 2;

                // 对左半部分数组进行归并排序
                MergeSort(arr, left, mid);

                // 对右半部分数组进行归并排序
                MergeSort(arr, mid + 1, right);

                // 合并两个有序数组
                Merge(arr, left, mid, right);
            }
        }

        public static void Merge(int[] arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1; // 左半部分数组的长度
            int n2 = right - mid;    // 右半部分数组的长度

            // 创建临时数组
            int[] leftArr = new int[n1];
            int[] rightArr = new int[n2];

            // 将数据拷贝到临时数组
            for (int i = 0; i < n1; ++i)
            {
                leftArr[i] = arr[left + i];
            }

            for (int j = 0; j < n2; ++j)
            {
                rightArr[j] = arr[mid + 1 + j];
            }

            // 合并两个有序数组
            int k = left;   // 初始化合并后的数组索引
            int p = 0;      // 初始化左半部分数组的索引
            int q = 0;      // 初始化右半部分数组的索引

            while (p < n1 && q < n2)
            {
                if (leftArr[p] <= rightArr[q])
                {
                    arr[k] = leftArr[p];
                    p++;
                }
                else
                {
                    arr[k] = rightArr[q];
                    q++;
                }
                k++;
            }

            // 复制左半部分数组的剩余元素
            while (p < n1)
            {
                arr[k] = leftArr[p];
                p++;
                k++;
            }

            // 复制右半部分数组的剩余元素
            while (q < n2)
            {
                arr[k] = rightArr[q];
                q++;
                k++;
            }
        }

        public static void MergeSortRun()
        {
            int[] array = { 19, 27, 46, 48, 50, 2, 4, 44, 47, 36, 38, 15, 26, 5, 3 };

            Console.WriteLine("排序前数组：" + string.Join(", ", array));

            MergeSort(array, 0, array.Length - 1);

            Console.WriteLine("排序后数组：" + string.Join(", ", array));
        }
    }
}

namespace HelloDotNetGuide.常见算法
{
    public class 堆排序算法
    {
        public static void HeapSort(int[] array)
        {
            int arrayLength = array.Length;

            //构建最大堆
            for (int i = arrayLength / 2 - 1; i >= 0; i--)
                Heapify(array, arrayLength, i);

            //依次取出堆顶元素，并重新调整堆
            for (int i = arrayLength - 1; i >= 0; i--)
            {
                //将堆顶元素与当前最后一个元素交换
                int temp = array[0];
                array[0] = array[i];
                array[i] = temp;

                //重新调整堆
                Heapify(array, i, 0);
            }
        }

        private static void Heapify(int[] arr, int n, int i)
        {
            int largest = i; //假设父节点最大
            int left = 2 * i + 1; //左子节点
            int right = 2 * i + 2; //右子节点

            //如果左子节点大于父节点，则更新最大值
            if (left < n && arr[left] > arr[largest])
                largest = left;

            //如果右子节点大于父节点和左子节点，则更新最大值
            if (right < n && arr[right] > arr[largest])
                largest = right;

            //如果最大值不是当前父节点，则交换父节点和最大值，并继续向下调整堆
            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;

                Heapify(arr, n, largest);
            }
        }

        public static void HeapSortRun()
        {
            int[] array = { 19, 27, 46, 48, 50, 2, 4, 44, 47, 36, 38, 15, 26, 5, 3, 99, 888, 0, -1 };

            Console.WriteLine("排序前数组：" + string.Join(", ", array));

            HeapSort(array);

            Console.WriteLine("排序后数组：" + string.Join(", ", array));
        }
    }
}

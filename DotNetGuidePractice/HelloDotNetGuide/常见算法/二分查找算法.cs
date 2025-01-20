namespace HelloDotNetGuide.常见算法
{
    public class 二分查找算法
    {
        /// <summary>
        /// 二分查找算法
        /// </summary>
        /// <param name="arr">arr是已排序的数组</param>
        /// <param name="target">target是要查找的目标值</param>
        /// <returns>目标值在数组中的索引，如果未找到则返回-1</returns>
        public static int BinarySearch(int[] arr, int target)
        {
            int left = 0; // 定义左指针
            int right = arr.Length - 1; // 定义右指针

            while (left <= right)
            {
                // 计算中间元素的索引
                int mid = left + (right - left) / 2;

                if (arr[mid] == target)
                {
                    // 如果中间元素等于目标值
                    return mid; // 查找成功，返回索引
                }
                else if (arr[mid] < target)
                {
                    // 如果目标值大于中间元素，则在右半部分查找
                    left = mid + 1;
                }
                else
                {
                    // 如果目标值小于中间元素，则在左半部分查找
                    right = mid - 1;
                }
            }

            // 未找到 target，返回-1
            return -1;
        }

        public static void BinarySearchRun()
        {
            int[] arr = { 1, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59 }; //注意：这里的数组是已排序的数组
            int target = 31; //需要要查找的目标值

            int result = BinarySearch(arr, target); //调用二分查找方法

            if (result == -1)
            {
                Console.WriteLine("元素未找到");
            }
            else
            {
                Console.WriteLine($"元素找到，索引为：{result}，值为：{arr[result]}");
            }
        }
    }
}

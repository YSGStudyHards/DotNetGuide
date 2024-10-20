namespace HelloDotNetGuide.常见算法
{
    public class 线性查找算法
    {
        public static void LinearSearchRun()
        {
            int[] arr = { 2, 3, 4, 10, 40, 50, 100, 77, 88, 99 };
            int target = 100;

            int result = LinearSearch(arr, target);

            // 输出结果
            if (result == -1)
            {
                Console.WriteLine("元素未找到");
            }
            else
            {
                Console.WriteLine($"元素在索引 {result} 处找到，index = {result}");
            }
        }

        /// <summary>
        /// 线性查找函数
        /// </summary>
        /// <param name="arr">arr</param>
        /// <param name="target">target</param>
        /// <returns></returns>
        public static int LinearSearch(int[] arr, int target)
        {
            // 遍历数组
            for (int i = 0; i < arr.Length; i++)
            {
                // 如果找到目标值，返回其索引
                if (arr[i] == target)
                {
                    return i;
                }
            }
            // 如果没有找到，则返回-1
            return -1;
        }
    }
}

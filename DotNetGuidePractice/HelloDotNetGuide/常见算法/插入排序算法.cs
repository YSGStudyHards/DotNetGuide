namespace HelloDotNetGuide.常见算法
{
    public class 插入排序算法
    {
        public static void InsertionSort(int[] array)
        {
            int arrayLength = array.Length;//数组长度（时间复杂度为O(n^2)）
            for (int i = 1; i < arrayLength; ++i)
            {
                //定义临时变量
                int temp = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > temp)
                {
                    array[j + 1] = array[j];
                    j--;
                }

                array[j + 1] = temp;
            }
        }

        public static void InsertionSortRun()
        {
            int[] array = { 26, 15, 5, 3, 38, 36, 44, 27, 47, 2, 46, 4, 50, 19, 48 };

            Console.WriteLine("排序前:" + string.Join(", ", array));

            InsertionSort(array);

            Console.WriteLine("排序后:" + string.Join(", ", array));
        }
    }
}

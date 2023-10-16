namespace HelloDotNetGuide.常见算法
{
    public class 桶排序算法
    {
        public static void BucketSort(int[] array)
        {
            int arrLength = array.Length;
            if (arrLength <= 1)
            {
                return;
            }

            //确定桶的数量
            int maxValue = array[0], minValue = array[0];
            for (int i = 1; i < arrLength; i++)
            {
                if (array[i] > maxValue)
                    maxValue = array[i];
                if (array[i] < minValue)
                    minValue = array[i];
            }
            int bucketCount = (maxValue - minValue) / arrLength + 1;

            //创建桶并将数据放入桶中
            List<List<int>> buckets = new List<List<int>>(bucketCount);
            for (int i = 0; i < bucketCount; i++)
            {
                buckets.Add(new List<int>());
            }

            for (int i = 0; i < arrLength; i++)
            {
                int bucketIndex = (array[i] - minValue) / arrLength;
                buckets[bucketIndex].Add(array[i]);
            }

            //对每个非空的桶进行排序
            int index = 0;
            for (int i = 0; i < bucketCount; i++)
            {
                if (buckets[i].Count == 0)
                {
                    continue;
                }

                int[] tempArr = buckets[i].ToArray();
                Array.Sort(tempArr);

                foreach (int num in tempArr)
                {
                    array[index++] = num;
                }
            }
        }

        public static void BucketSortRun()
        {
            int[] array = { 19, 27, 46, 48, 50, 2, 4, 44, 47, 36, 38, 15, 26, 5, 3, 99, 888 };

            Console.WriteLine("排序前数组：" + string.Join(", ", array));

            BucketSort(array);

            Console.WriteLine("排序后数组：" + string.Join(", ", array));
        }
    }
}

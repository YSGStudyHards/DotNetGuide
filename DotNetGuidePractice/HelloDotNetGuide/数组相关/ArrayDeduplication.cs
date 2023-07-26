namespace HelloDotNetGuide.数组相关
{
    /// <summary>
    /// C#数组数据去重的常见方式
    /// </summary>
    public class ArrayDeduplication
    {
        /// <summary>
        /// 使用HashSet去重
        /// TODO:HashSet是一个集合类，它的特点是不允许重复元素，可以方便地实现去重功能。
        /// </summary>
        public static void HashSetDuplicate()
        {
            var dataSource = new List<int>() { 1, 2, 3, 2, 5, 88, 99, 99, 100, 88, 30, 50, 15, 100, 99, 99, 2, 3 };
            HashSet<int> uniqueData = new HashSet<int>(dataSource);

            Console.WriteLine(string.Join(", ", uniqueData));
        }

        /// <summary>
        /// 使用Linq的Distinct()方法去重
        /// </summary>
        public static void DistinctDuplicate()
        {
            var dataSource = new List<int>() { 1, 2, 3, 2, 5, 88, 99, 99, 100, 88, 30, 50, 15, 100, 99, 99, 2, 3 };
            var uniqueData = dataSource.Distinct();

            Console.WriteLine(string.Join(", ", uniqueData));
        }

        /// <summary>
        /// 使用Linq的GroupBy()方法去重
        /// </summary>
        public static void GroupByDuplicate()
        {
            var dataSource = new List<int>() { 1, 2, 3, 2, 5, 88, 99, 99, 100, 88, 30, 50, 15, 100, 99, 99, 2, 3 };

            //GroupBy()方法将原始集合中的元素进行分组，根据指定的键或条件进行分组。每个分组都会有一个唯一的键，通过将原始集合分组并选择每个分组中的第一个元素，实现了去重的效果。
            var uniqueData = dataSource.GroupBy(item => item).Select(group => group.First()).ToList();

            Console.WriteLine(string.Join(", ", uniqueData));
        }

        /// <summary>
        /// 使用自定义的比较器和循环遍历
        /// </summary>
        public static void CustomEqualityComparerDuplicate()
        {
            var dataSource = new List<int>() { 1, 2, 3, 2, 5, 88, 99, 99, 100, 88, 30, 50, 15, 100, 99, 99, 2, 3 };
            var uniqueData = new List<int>();
            foreach (var item in dataSource)
            {
                if (!uniqueData.Contains(item, new CustomEqualityComparer()))
                {
                    uniqueData.Add(item);
                }
            }
            Console.WriteLine(string.Join(", ", uniqueData));
        }

        /// <summary>
        /// 直接循环遍历去重
        /// </summary>
        public static void LoopTraversalDuplicate()
        {
            var dataSource = new List<int>() { 1, 2, 3, 2, 5, 88, 99, 99, 100, 88, 30, 50, 15, 100, 99, 99, 2, 3 };
            var uniqueData = new List<int>();
            foreach (var item in dataSource)
            {
                //if (!uniqueData.Any(x => x == item))
                //if (!uniqueData.Exists(x => x == item))
                if (!uniqueData.Contains(item))
                {
                    uniqueData.Add(item);
                }
            }
            Console.WriteLine(string.Join(", ", uniqueData));
        }
    }

    /// <summary>
    /// 自定义的比较器
    /// </summary>
    public class CustomEqualityComparer : IEqualityComparer<int>
    {
        public bool Equals(int x, int y)
        {
            return x == y;
        }

        public int GetHashCode(int obj)
        {
            return obj.GetHashCode();
        }
    }
}

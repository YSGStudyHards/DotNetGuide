namespace HelloDotNetGuide.常见算法
{
    public class 哈希查找算法
    {
        /// <summary>
        /// 哈希查找函数
        /// </summary>
        /// <param name="target">target</param>
        public static void HashSearchFunctionRun(int target)
        {
            //创建一个字典来存储键值对
            var dic = new Dictionary<int, string>();
            dic.Add(1, "one");
            dic.Add(2, "two");
            dic.Add(3, "three");

            //查找目标值是否在Dictionary中存在
            //TryGetValue方法可以返回一个bool值和值，如果找到了目标值，则返回true和对应的值，否则返回false和默认值
            string value;
            if (dic.TryGetValue(target, out value))
            {
                Console.WriteLine("Found Data: " + value);
            }
            else
            {
                Console.WriteLine("Not Found Data.");
            }
        }
    }
}

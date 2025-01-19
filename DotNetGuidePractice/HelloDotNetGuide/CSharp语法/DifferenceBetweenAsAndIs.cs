namespace HelloDotNetGuide.CSharp语法
{
    public class DifferenceBetweenAsAndIs
    {
        public static void IsOperator()
        {
            #region 检查对象是否是某个特定类型

            string title = "Hello DotNetGuide";

            if (title is string)
            {
                Console.WriteLine("是 string 类型");
            }
            else
            {
                Console.WriteLine("不是 string 类型");
            }

            if (title is not null)
            {
                Console.WriteLine("不为 null");
            }
            else
            {
                Console.WriteLine("为 null");
            }

            #endregion

            #region 模式匹配

            object obj = "追逐时光者";

            if (obj is string str)
            {
                Console.WriteLine($" {str}");
            }
            else
            {
                Console.WriteLine("不是指定类型");
            }

            #endregion

            #region 列表模式

            int[] empty = [];
            int[] one = [1];
            int[] odd = [1, 3, 5];
            int[] even = [2, 4, 6];
            int[] fib = [1, 1, 2, 3, 5];

            Console.WriteLine(odd is [1, _, 2, ..]);   // false
            Console.WriteLine(fib is [1, _, 2, ..]);   // true
            Console.WriteLine(fib is [_, 1, 2, 3, ..]);     // true
            Console.WriteLine(fib is [.., 1, 2, 3, _]);     // true
            Console.WriteLine(even is [2, _, 6]);     // true
            Console.WriteLine(even is [2, .., 6]);    // true
            Console.WriteLine(odd is [.., 3, 5]); // true
            Console.WriteLine(even is [.., 3, 5]); // false
            Console.WriteLine(fib is [.., 3, 5]); // true

            #endregion
        }

        public static void AsOperator()
        {
            object title = "Hello DotNetGuide";
            string str = title as string;

            if (str != null)
            {
                Console.WriteLine("是 string 类型: " + str);
            }
            else
            {
                Console.WriteLine("不是 string 类型");
            }

            int? num = title as int?;

            if (num.HasValue)
            {
                Console.WriteLine("是 int 类型: " + num.Value);
            }
            else
            {
                Console.WriteLine("不是 int 类型");
            }

            IEnumerable<int> numbers = new List<int>() { 10, 20, 30 };
            IList<int> indexable = numbers as IList<int>;
            if (indexable != null)
            {
                Console.WriteLine(indexable[0] + indexable[indexable.Count - 1]);  // output: 40
            }
        }
    }
}

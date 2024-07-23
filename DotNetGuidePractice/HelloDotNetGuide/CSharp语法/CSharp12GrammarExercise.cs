using PointTest = (int item1, int item2);

namespace HelloDotNetGuide.CSharp语法
{
    public class CSharp12GrammarExercise
    {
        public static void OutputPrint()
        {
            //使用 using 关键字为元组类型创建别名，并进行调用：
            PointTest point = (10, 20);
            Console.WriteLine($"输出：Item1={point.Item1}, Item2={point.Item2}");

            //InlineArrays();
            //CollectionExpressions();
            //var person = new Person("追逐时光者", 30);
            //Console.WriteLine($"{person.Name}, {person.Age}");

            //// 创建 Distance 结构体实例
            //Distance distance = new Distance(10, 55);
            //// 访问 Magnitude 和 Direction 属性
            //Console.WriteLine($"Magnitude: {distance.Magnitude}，Direction: {distance.Direction}");
        }

        #region 默认 lambda 参数

        public static void DefaultLambdaParameters()
        {
            Func<double, double> testcube = x => x * x * x;
            Func<int, int, bool> testForEquality = (x, y) => x == y;
            Func<int, string, bool> isTooLong = (int x, string s) => s.Length > x;
        }

        #endregion

        #region 集合表达式

        public static void CollectionExpressions()
        {
            // 创建一个数组
            int[] array = [55, 99, 100, 33];

            // 创建一个列表
            List<string> list = ["one", "two", "three", "five", "追逐时光者"];

            // 创建一个 Span
            Span<char> span = ['a', 'b', 'c', 'd', 'e', 'f', 'h', 'i', 'k'];

            // 创建一个交错二维数组
            int[][] two2D = [[1, 2, 3], [4, 5, 6], [7, 8, 9], [88, 8, 9]];

            int[] item0 = [88, 2, 3];
            int[] item1 = [22, 5, 6];
            int[] item2 = [7, 99, 9];
            int[] totalList = [.. item0, .. item1, .. item2];
            foreach (var element in totalList)
            {
                Console.Write($"{element}, ");
            }
        }

        #endregion

        #region 内联数组

        public static void InlineArrays()
        {
            var buffer = new Buffer();
            for (int i = 0; i < 20; i++)
            {
                buffer[i] = i;
            }

            foreach (var i in buffer)
            {
                Console.WriteLine(i);
            }
        }

        #endregion
    }

    #region 主构造函数

    public readonly struct Distance(double dx, double dy)
    {
        public readonly double Magnitude { get; } = Math.Sqrt(dx * dx + dy * dy);
        public readonly double Direction { get; } = Math.Atan2(dy, dx);
    }

    public class Person(string name, int age)
    {
        public string Name => name;
        public int Age => age;
    }

    #endregion

    [System.Runtime.CompilerServices.InlineArray(20)]
    public struct Buffer
    {
        private int _element0;
    }
}

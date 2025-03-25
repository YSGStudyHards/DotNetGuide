using System.Runtime.CompilerServices;

namespace HelloDotNetGuide.CSharp语法
{
    public class CSharp13GrammarExercise
    {
        #region params 集合

        public static void SpanDataPrintRun()
        {
            Span<int> originalSpan = [1, 2, 3, 4, 5];
            SpanDataPrint(originalSpan);
        }

        public static void SpanDataPrint<T>(params Span<T> spans)
        {
            for (int i = 0; i < spans.Length; i++)
            {
                Console.WriteLine(spans[i]);
            }
        }

        #endregion

        #region 新增Lock锁对象

        private object _oldLock = new object();
        private System.Threading.Lock _newLock = new System.Threading.Lock();

        public void LockTest()
        {
            lock (_oldLock)
            {
                Console.WriteLine("Old lock");
            }


            lock (_newLock)
            {
                // 传统 lock 语法（优化版）
            }

            using (_newLock.EnterScope())
            {
                //  作用域自动释放（推荐写法）
            }

            _newLock.Enter();
            try
            {
                // 显式 Enter/Exit 调用
            }
            finally { _newLock.Exit(); }

            if (_newLock.TryEnter())
            {
                try
                {
                    // 非阻塞尝试获取锁
                }
                finally { _newLock.Exit(); }
            }

        }

        #endregion

        #region 新的转义序列

        public static void NewEscapeSequence()
        {
            Console.WriteLine("[31m红色文本[0m");

            // C# 13 之前
            Console.WriteLine("\u001b[31m红色文本\u001b[0m"); //输出红色文字

            // C# 13 中
            Console.WriteLine("\e[31m红色文本\e[0m");//功能相同，语法更简洁
        }


        #endregion

        #region 隐式索引访问

        public class Numbers
        {
            public int[] Datas { get; set; } = new int[8];
        }

        public static void ImplicitIndexAccess()
        {
            var countdown = new Numbers()
            {
                Datas =
                {
                   [1] = 0,
                   [2] = 1,
                    
                   // 从 C# 13 开始可以执行下面方式赋值
                   [^3] = 2,
                   [^4] = 3,
                   [^5] = 4
                }
            };
        }

        #endregion

        #region 重载解析优先级

        [OverloadResolutionPriority(1)] //优先调用
        public static void PrintWay(params int[] numberList) { }

        public static void PrintWay(params ReadOnlySpan<int> numberList) { }

        #endregion
    }

    #region partial类型中现在允许使用部分属性和索引器

    public partial class MyClass
    {
        public partial string Name { get; set; }
    }

    public partial class MyClass
    {
        private string _name;
        public partial string Name
        {
            get => _name;
            set => _name = value;
        }
    }

    #endregion
}

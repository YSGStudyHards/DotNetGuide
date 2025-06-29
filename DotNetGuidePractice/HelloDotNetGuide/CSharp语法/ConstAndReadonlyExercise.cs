namespace HelloDotNetGuide.CSharp语法
{
    public enum UserRole
    {
        Admin,
        User,
        Guest
    }

    public class ConstAndReadonlyExercise
    {
        // const 初始化
        public const int MaxCount = 0;
        public const UserRole CurrentUserRole = UserRole.Admin;

        // readonly 初始化
        public readonly string _applicationName;

        public ConstAndReadonlyExercise()
        {
            _applicationName = "HelloDotNetGuide_V2";
        }

        // 懒汉式单例模式示例
        private static ConstAndReadonlyExercise? _instance;
        private static readonly object _lockObj = new object();

        public static ConstAndReadonlyExercise Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lockObj)
                    {
                        _instance ??= new ConstAndReadonlyExercise();
                    }
                }
                return _instance;
            }
        }

        /// <summary>
        /// 反射修改 readonly 字段的值
        /// </summary>
        public static void UpdateApplicationNameValue()
        {
            var instance = new ConstAndReadonlyExercise();
            Console.WriteLine($"初始值: {instance._applicationName}");
            // 输出: 初始值: HelloDotNetGuide_V2

            var field = instance.GetType().GetField("_applicationName");
            field.SetValue(instance, "HelloDotNetGuide_V3");

            Console.WriteLine($"修改后: {instance._applicationName}");
            // 输出: 修改后: HelloDotNetGuide_V3
        }

        /// <summary>
        /// 打印所有常量和只读字段的值
        /// </summary>
        public static void PrintAllValues()
        {
            Console.WriteLine($"MaxCount: {MaxCount}");
            Console.WriteLine($"CurrentUserRole: {CurrentUserRole}");
            Console.WriteLine($"ApplicationName: {Instance._applicationName}");
        }
    }
}

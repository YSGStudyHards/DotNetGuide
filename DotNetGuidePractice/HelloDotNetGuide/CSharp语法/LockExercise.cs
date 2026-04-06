using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDotNetGuide.CSharp语法
{
    public class LockExercise
    {
        /// <summary>
        /// 传统方式（老锁 - 在 .NET 9 和 C# 13 以前）
        /// </summary>
        public class OldLockExample
        {
            // 必须定义一个 object 作为锁对象
            private readonly object _syncRoot = new object();
            private int _counter = 0;

            public void Increment()
            {
                // 编译器会将其转化为 Monitor.Enter 和 try-finally 中的 Monitor.Exit
                lock (_syncRoot)
                {
                    _counter++;
                    Console.WriteLine($"Counter: {_counter}");
                }

                //object __lockObj = x;
                //bool __lockWasTaken = false;
                //try
                //{
                //    System.Threading.Monitor.Enter(__lockObj, ref __lockWasTaken);
                //    // Your code...
                //}
                //finally
                //{
                //    if (__lockWasTaken) System.Threading.Monitor.Exit(__lockObj);
                //}
            }
        }

        /// <summary>
        /// 新锁 (System.Threading.Lock .NET 9 和 C# 13 开始)
        /// </summary>
        public class NewLockExample
        {
            // 1. 明确声明这是一个专用的 Lock 对象
            private readonly Lock _myLock = new Lock();
            private int _counter = 0;

            public void Increment()
            {
                // 2. C# 13 编译器识别到 _myLock 是 System.Threading.Lock
                // 自动使用底层的 _myLock.Enter() 和 Exit() 进行优化
                lock (_myLock)
                {
                    _counter++;
                    Console.WriteLine($"Counter: {_counter}");
                }
            }

            // 带有超时时间的尝试获取锁 (类似以前的 Monitor.TryEnter)
            public void TryIncrement()
            {
                if (_myLock.TryEnter(TimeSpan.FromMilliseconds(100)))
                {
                    try
                    {
                        _counter++;
                    }
                    finally
                    {
                        _myLock.Exit();
                    }
                }
                else
                {
                    Console.WriteLine("未能获取到锁");
                }
            }
        }

        /// <summary>
        /// 新锁 System.Threading.Lock 类型的四种不同用法（.NET 9 和 C# 13 引入的）
        /// </summary>
        public class NewLockUsageDemo
        {
            // 创建一个新的 Lock 实例作为锁对象（.NET 9 新增类型）
            // 使用 readonly 确保锁对象在初始化后不会被替换，避免线程安全问题
            private readonly Lock _lockObj = new();

            public void Modify()
            {
                // ============================================================
                // 方式一：使用 lock 语句（推荐，最简洁）
                // C# 13 编译器会自动识别 Lock 类型，
                // 将其编译为 Lock.EnterScope() 而非传统的 Monitor.Enter()
                // 退出作用域时自动释放锁，即使发生异常也能保证释放
                // ============================================================
                lock (_lockObj)
                {
                    // 与 _lockObj 关联的临界区（线程安全代码区域）
                }

                // ============================================================
                // 方式二：使用 EnterScope() + using 语句
                // EnterScope() 获取锁并返回一个 Lock.Scope（ref struct 值类型）
                // using 语句确保在作用域结束时自动调用 Scope.Dispose() 释放锁
                // 优点：零堆分配（ref struct 分配在栈上），性能优异
                // ============================================================
                using (_lockObj.EnterScope())
                {
                    // 与 _lockObj 关联的临界区
                }

                // ============================================================
                // 方式三：手动调用 Enter() / Exit()
                // Enter() —— 阻塞当前线程直到成功获取锁
                // Exit()  —— 释放锁
                // 必须使用 try/finally 确保异常情况下锁一定被释放
                // 适用于需要更精细控制锁的获取和释放时机的场景
                // ============================================================
                _lockObj.Enter();
                try
                {
                    // 与 _lockObj 关联的临界区
                }
                finally
                {
                    _lockObj.Exit(); // 无论是否发生异常，都必须释放锁
                }

                // ============================================================
                // 方式四：使用 TryEnter() 尝试获取锁（非阻塞）
                // TryEnter() 立即尝试获取锁：
                //   - 成功 → 返回 true，进入临界区
                //   - 失败 → 返回 false，跳过临界区（不会阻塞等待）
                // 适用于：不想让线程因等待锁而长时间阻塞的场景
                // 也可使用 TryEnter(TimeSpan timeout) 指定等待超时时间
                // ============================================================
                if (_lockObj.TryEnter())
                {
                    try
                    {
                        // 与 _lockObj 关联的临界区
                    }
                    finally
                    {
                        _lockObj.Exit(); // 获取成功后，必须在 finally 中释放锁
                    }
                }
                // 如果 TryEnter() 返回 false，则不进入临界区，程序继续执行
            }
        }
    }
}

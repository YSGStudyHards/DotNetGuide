using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDotNetGuide.CSharp语法
{
    public class ExtensionMethodExercise
    {
        public static void CheckEmail()
        {
            string email = "user@example.com";
            //Console.WriteLine(email.IsValidEmail()); // True
        }
    }

    /// <summary>
    /// 扩展方法传统语法（C# 3.0 - 13）
    /// 必须定义在静态类中
    /// </summary>
    public static class StringExtensions
    {
        // 必须是静态方法，第一个参数使用 this 修饰
        public static bool IsNullOrEmpty(this string str)
        {
            return string.IsNullOrEmpty(str);
        }

        public static string Truncate(this string str, int maxLength)
        {
            if (string.IsNullOrEmpty(str) || str.Length <= maxLength)
                return str;
            return str.Substring(0, maxLength) + "...";
        }

        public static int WordCount(this string str)
        {
            return str.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
        }

        // 判断字符串是否为有效的电子邮件格式
        public static bool IsValidEmail(this string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;
            return System.Text.RegularExpressions.Regex.IsMatch(
                email, @"^[^@\s]+@[^@\s]+\.[^@\.s]+$");
        }
    }

    /// <summary>
    /// 扩展方法 C# 14 新语法
    /// </summary>
    public static class NewStringExtensionsCSharp14
    {
        // 使用 extension 块，指定扩展的目标类型
        extension(string str)
        {
            // 方法内部直接使用 'str'（即 this 上下文）
            public bool IsNullOrEmpty()
            {
                return string.IsNullOrEmpty(str);
            }

            // 可直接定义方法（无需 this 参数）
            public int WordCount()
            {
                return str.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
            }

            public string Truncate(int maxLength)
            {
                if (string.IsNullOrEmpty(str) || str.Length <= maxLength)
                    return str;
                return str.Substring(0, maxLength) + "...";
            }

            // 判断字符串是否为有效的电子邮件格式
            public bool IsValidEmail()
            {
                if (string.IsNullOrWhiteSpace(str)) return false;
                return System.Text.RegularExpressions.Regex.IsMatch(
                    str, @"^[^@\s]+@[^@\s]+\.[^@\.s]+$");
            }

            // 新增能力：可以定义属性！
            public int LengthExcludingSpaces => str.Replace(" ", "").Length;

            // 甚至可以定义静态成员（扩展类型的“静态上下文”）
            public static string CreateGreeting(string name) => $"Hello, {name}!";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HelloDotNetGuide.正则表达式
{
    public class RegularExpressions
    {
        /// <summary>
        /// 验证邮箱地址
        /// </summary>
        public static void VerifyEmailAddress()
        {
            string email = "edwin.doe@qq.com";
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            var regex = new Regex(pattern);
            bool isValid = regex.IsMatch(email);
            Console.WriteLine($"{email} is valid email address: {isValid}");
        }

        /// <summary>
        /// 验证手机号码
        /// </summary>
        public static void VerifyMobilePhone()
        {
            string mobile = "13812345678";
            string pattern = @"^1[3-9]\d{9}$";
            var regex = new Regex(pattern);
            bool isValid = regex.IsMatch(mobile);
            Console.WriteLine($"{mobile} is valid mobile phone number: {isValid}");
        }

        /// <summary>
        /// 提取URL
        /// </summary>
        public static void ExtractUrl()
        {
            string url = "https://github.com/YSGStudyHards/DotNetGuide";
            string pattern = @"^https?://(?:[a-zA-Z]|[0-9]|[$-_@.&+]|[!*\(\),]|(?:%[0-9a-fA-F][0-9a-fA-F]))+$";
            var regex = new Regex(pattern);
            Match match = regex.Match(url);
            if (match.Success)
            {
                Console.WriteLine($"Found URL: {match.Value}"); //Output：https://github.com/YSGStudyHards/DotNetGuide
            }
            else
            {
                Console.WriteLine("No URL found.");
            }
        }

        /// <summary>
        /// 替换文本
        /// </summary>
        public static void ReplaceText()
        {
            string input = "The date is 2024/12/16.";
            string pattern = @"(\d{4})/(\d{2})/(\d{2})";
            string replacement = "$1-$2-$3";
            var regex = new Regex(pattern);
            string result = regex.Replace(input, replacement);
            Console.WriteLine(result);//Output:The date is 2024-12-16.
        }

        /// <summary>
        /// 分割字符串
        /// </summary>
        public static void SplitString()
        {
            string pattern = @"[;,]";
            string input = "apple;banana,orange;grape";
            var regex = new Regex(pattern);
            string[] substrings = regex.Split(input);
            foreach (string substring in substrings)
            {
                Console.WriteLine(substring);
                //Output:
                //apple
                //banana
                //orange
                //grape
            }
        }
    }
}

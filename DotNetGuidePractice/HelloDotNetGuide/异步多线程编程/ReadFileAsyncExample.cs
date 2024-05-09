namespace HelloDotNetGuide.异步多线程编程
{
    /// <summary>
    /// 使用C#异步方法来进行文件内容读取操作
    /// </summary>
    public class ReadFileAsyncExample
    {
        /// <summary>
        /// 异步方法读取文件内容
        /// 当涉及到C#的异步编程时，你可以使用 async 和 await 关键字来实现
        /// </summary>
        /// <param name="filePath">文件地址</param>
        /// <returns></returns>
        public static async Task<string> ReadFileAsync(string filePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    // 异步读取文件内容并等待完成
                    string content = await reader.ReadToEndAsync();
                    return content;
                }
            }
            catch (FileNotFoundException)
            {
                return "文件未找到";
            }
            catch (Exception ex)
            {
                return $"发生错误：{ex.Message}";
            }
        }
    }
}

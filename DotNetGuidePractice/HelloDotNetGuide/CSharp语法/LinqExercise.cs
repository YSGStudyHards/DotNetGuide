using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDotNetGuide.CSharp语法
{
    public class LinqExercise
    {
        #region .NET 9 中 LINQ 新增的功能

        //public static void CountByExample()
        //{
        //    //这里wordCounts是一个字典，包含每个单词及其出现次数的键值对
        //    var sourceText = "This is a test text. This is only a test. This is the best. This，This，This";
        //    KeyValuePair<string, int> mostFrequentWord = sourceText
        //    .Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries)
        //    .Select(word => word.ToLowerInvariant())
        //    .CountBy(word => word)
        //    .MaxBy(pair => pair.Value);

        //    Console.WriteLine($"最常见的词是：'{mostFrequentWord.Key}'  {mostFrequentWord.Value}");
        //}

        //public static void AggregateByExample()
        //{
        //    (string id, int score)[] data =
        //        [
        //            ("0", 88),
        //        ("1", 5),
        //        ("2", 4),
        //        ("1", 10),
        //        ("6", 5),
        //        ("4", 10),
        //        ("6", 25)
        //        ];

        //    // aggregatedData 是一个序列，包含按姓名分组并计算总分的元素
        //    var aggregatedData =
        //        data.AggregateBy(
        //            keySelector: entry => entry.id,
        //            seed: 0,
        //            (totalScore, curr) => totalScore + curr.score
        //            );

        //    foreach (var item in aggregatedData)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        //public static void IndexExample()
        //{
        //    var lines = new List<string> { "First line", "Second line", "Third line" };
        //    foreach (var (index, line) in lines.Index())
        //    {
        //        Console.WriteLine($"Line {index + 1}: {line}");
        //    }
        //}

        #endregion
    }
}

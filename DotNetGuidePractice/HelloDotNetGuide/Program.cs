using HelloDotNetGuide.CSharp语法;
using HelloDotNetGuide.常见算法;
using HelloDotNetGuide.异步多线程编程;
using HelloDotNetGuide.数组相关;

namespace HelloDotNetGuide
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎来到DotNetGuide练习空间！！！");

            #region GotoExercise

            //GotoExercise.GotoRetryUseExample();
            //GotoExercise.NonGotoRetryUseExample();

            #endregion

            #region 异步多线程编程

            //var getFileContent = ReadFileAsyncExample.ReadFileAsync("D:\\Desktop\\数据读取.txt").ConfigureAwait(false);

            //MultithreadingExample.ParallelMethod();

            AsyncProgrammingExample.TestEAPAsync();

            #endregion

            #region 常见算法

            //递归算法.RecursiveFactorial();
            //递归算法.RecursiveArraySum();
            //递归算法.FibonacciSum();
            //递归算法.RecursiveAlgorithmSum();
            //基数排序算法.RadixSortRun();
            //桶排序算法.BucketSortRun();
            //计数排序算法.CountingSortRun();
            //堆排序算法.HeapSortRun();
            //归并排序算法.MergeSortRun();
            //希尔排序算法.ShellSortRun();
            //插入排序算法.InsertionSortRun();
            //快速排序算法.QuickSortRun();
            //冒泡排序算法.RecursiveBubbleSortRun();
            //List集合相关算法.GetAfterRemoveListData();
            //选择排序算法.SelectionSortAlgorithmMain();

            #endregion

            #region 数组相关

            //ArrayDeduplication.LoopTraversalDuplicate();

            #endregion
        }
    }
}
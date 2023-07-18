using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDotNetGuide.常见算法
{
    public class 选择排序算法
    {
        /// <summary>
        /// 选择排序算法
        /// 选择排序算法的核心思想是每次从未排序的部分中找到最小元素，然后将其与未排序部分的第一个元素交换位置。
        /// 通过不断进行这个过程，逐步将最小元素放到正确的位置，完成整个数组的排序。
        /// </summary>
        public static void SelectionSortAlgorithmMain()
        {
            int[] array = { 64, 25, 12, 22, 11 };

            Console.WriteLine("原始数组: ");
            PrintArray(array);

            SelectionSortAlgorithm(array);

            Console.WriteLine("排序后的数组: ");
            PrintArray(array);
        }

        static void SelectionSortAlgorithm(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                // 在未排序部分中找到最小元素的索引
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // 将最小元素与未排序部分的第一个元素交换位置
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
        }

        static void PrintArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}

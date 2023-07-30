# C#经典算法面试题
> 🤞欢迎留下您的C#高频面试算法题！！！

# 递归算法
## 使用递归算法来实现计算1+2+3+4+…+100的结果

```C#
static int SUM(int x)
{
  if (x <= 1)
    return x;
    else
    return x + SUM(x - 1);
}
```

## 一列数的规则如下 : 1 、 1 、 2 、 3 、 5 、 8 、 13 、 21 、 34… 求第 30 位数是多少， 用递归算法实现

```C#
static int Foo(int i)
{
    if (i <= 0)
        return 0;
    else if (i > 0 && i <= 2)
        return 1;
    else
        return Foo(i - 1) + Foo(i - 2);
}


static void Main(string[] args)  
{  
    int dataValue = Foo(30);  
    Console.WriteLine(dataValue.ToString());  
}  
```

# C#常见排序算法
## 冒泡排序算法[√]
### 双重循环方式实现冒泡排序
```C#
        /// <summary>
        /// 双重循环方式实现冒泡排序
        /// </summary>
        public static void BubbleSort()
        {
            int[] arr = { 1, 8, 9, 5, 6, 2, 3, 4, 7 };
            int arrLength = arr.Length;
            for (int i = 0; i < arrLength - 1; i++)
            {
                for (int j = 0; j < arrLength - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        //交换arr[j]和arr[j+1]的值
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("排序后结果：" + string.Join(", ", arr));
        }
```

### 递归方式实现冒泡排序
```C#
        /// <summary>
        /// 递归方式实现冒泡排序
        /// </summary>
        /// <param name="arr">arr</param>
        /// <param name="arrLength">arrLength</param>
        public static void RecursiveBubbleSort(int[] arr, int arrLength)
        {
            if (arrLength == 1)
                return;

            for (int i = 0; i < arrLength - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    //交换arr[i]和arr[i+1]的值
                    int temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                }
            }

            RecursiveBubbleSort(arr, arrLength - 1);
        }

        public static void RecursiveBubbleSortRun()
        {
            int[] arr = { 1, 8, 9, 5, 6, 2, 3, 4, 7 };
            int arrLength = arr.Length;
            RecursiveBubbleSort(arr, arrLength);
            Console.WriteLine("排序后结果：" + string.Join(", ", arr));
        }
```


## 选择排序算法[√]

> 选择排序是一种简单直观的排序算法，它的工作原理如下：
> 
> 选择排序算法的核心思想是每次从未排序的部分中找到最小元素，然后将其与未排序部分的第一个元素交换位置。通过不断进行这个过程，逐步将最小元素放到正确的位置，完成整个数组的排序。

```C#
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
```

 ![](assets/images/2023-07-19-00-08-11-6b0749ea6f6c3cc152c521bd3b6f91c.png)

# C#List集合相关[√]

## C#List RemoveAt（按照索引移除）、Remove（按照对象移除）

        /// <summary>
        /// 获取移除后的列表数据
        /// 考察内容：C#List RemoveAt（按照索引移除）、Remove（按照对象移除）
        /// </summary>
        /// <returns></returns>
        public static List<int> GetAfterRemoveListData()
        {
            List<int> list = new List<int>();
            for (int i = 1; i <= 10; i++)
            {
                list.Add(i);
            }
    
            for (int i = 0; i < 5; i++)
            {
                list.RemoveAt(i);//单独使用输出结果：2,4,6,8,10，按照索引移除
                list.Remove(i);//单独使用输出结果：5,6,7,8,9,10，按照对象移除
            }
    
            //以上两种同时使用时输出结果：6,7,9
            return list;
        }

# 其他

## 实现一个方法，对于输入的任意字符串，统计出其中每一种字符出现的次数

```C#
/** 字典的定义
 必须包含名空间System.Collection.Generic
 Dictionary里面的每一个元素都是一个键值对(由二个元素组成：键和值)
 键必须是唯一的,而值不需要唯一的
 键和值都可以是任何类型(比如：string, int, 自定义类型，等等)
 通过一个键读取一个值的时间是接近O(1)
 键值对之间的偏序可以不定义
*/
static void CountChar(string str)
{
    Dictionary<char, int> dic = new Dictionary<char, int>();
    foreach (char c in str)
    {
        if (dic.ContainsKey(c))
            dic[c]++;
        else
            dic.Add(c, 1);
    }
    foreach (KeyValuePair<char, int> p in dic)
    {
        Console.WriteLine("字符{0}，出现的次数{1}", p.Key.ToString(), p.Value.ToString());
    }
}
```

## 实现一个将字符串转换为整数的方法，不要使用int.Parse、int.TryParse、Convert.ToInt32等任何类库方法

```C#
        public static bool TryParseToInt(string strData, out int num)
        {
            if (string.IsNullOrWhiteSpace(strData))
            {
                num = 0;
                return false;
            }
            int result = 0;

            bool minus = strData[0] == '-' ? true : false;
            if (minus && strData.Length == 1)
            {
                num = 0;
                return false;
            }

            for (int i = minus ? 1 : 0; i < strData.Length; i++)
            {
                if (strData[i] >= '0' && strData[i] <= '9')
                {
                    result = strData[i] - 48 + result * 10;
                }
                else
                {
                    num = 0;
                    return false;
                }
            }

            num = minus ? -result : result;
            return true;
        }

        static void Main(string[] args)
        {
            //打印输出getValue为转化而成的整数
            var result = TryParseToInt("99", out int getValue);
        }
```

## 求以下表达式的值，写出您想到的一种或几种实现方法： 1-2+3-4+……+m

```C#
  //通过顺序规律写程序，同时也知道flag标志位的重要性
  static int F1(int m)  
    {  
        int sum =0;  
        bool flag =true;  
        for (int i = 1; i <= m; i++)  
        {  
            if (flag)  //一次是默认是True，下下也为True  
                sum += i;  
            else  
                sum -= i;  
            flag = !flag;  

        }  
        return sum;  
    }  

    //通过奇偶性  
    static int F2(int m)  
    {  
        int sum = 0;  
        for (int i = 1; i <= m; i++)  
        {  
            if (i % 2 >0)  //即为奇数  
                sum += i;  
            else  
                sum -= i;  
        }  
        return sum;  
    }  
```

## 有1、2、3、4个数字，能组成多少个互不相同且无重复数字的三位数？都是多少？

```C#
 class Program  
    {  
        static void Main(string[] args)  
        {  

            //有1、2、3、4个数字，能组成多少个互不相同且无重复数字的三位数？都是多少？  
            //分解题目  
            //条件：四个数字1、2、3、4  ；三位数：百位、十位、个位  
            //要求：互不相同；无重复数字：每个数字在三位中只出现一次  
            //结果：多少个？ 都是多少？  

            int count = 0; //统计个数  
            for (int bw = 1; bw <= 4; bw++)  
            {  
                for (int sw = 1; sw <= 4; sw++)  
                {  
                    if (sw!= bw)  //很显然，只有百位和十位不同的情况下才能谈个位。  
                    {  
                        for (int gw = 1; gw <= 4; gw++)  
                        {  
                            if (gw != sw && gw != bw)   //百位用过的，十位就不能用；百位和十位都用过的，个位就不能用  
                            {  
                                count++;  
                                Console.WriteLine("{0}{1}{2}", bw, sw, gw);  
                            }  
                        }  
                    }  
                }  
            }  
            Console.WriteLine("一共有{0}个", count);  
            Console.Read();  

        }  
    }   
```

## 一个6位数乘以一个3位数，得到一个结果。但不清楚6位数的两个数字是什么，而且结果中有一位数字也不清楚，请编程找出问好代表的数字，答案可能有多个。

> 表达式：12?56?*123 = 154?4987

```C#
 for (int a = 0; a < 10; a++)  
    {  
        for (int b = 0; b < 10; b++)  
        {  
            for (int c = 0; c < 10; c++)  
            {  
                if ((120560 + a + b * 1000) * 123 == 15404987 + c * 10000)  
                {  
                    Console.WriteLine(a);  
                    Console.WriteLine(b);  
                    Console.WriteLine(c);  
                }  
            }  
        }  
    }  
    Console.Read();  
```

## 有一个字符串 "I am a good man",设计一个函数,返回 "man good a am I"。

```C#
          static string Reverse()  
          {  
              string s = "I am a good man";  
              string[] arr = s.Split(' ');  
              string res = "";  
              for (int i = arr.Length - 1; i >= 0; i--)  
              {  
                  res += arr[i];  
                  if (i > 0)  
                      res += " ";  
              }  
              return res;  
          }  
```

## C# 九九乘法表算法实现

```C#
         static void Mu()  
          {  
              string t = string.Empty;  
              for (int i = 1; i < 10; i++)  
              {  
                  for (int j = 1; j <= i; j++)  
                  {  
                      t = string.Format("{0}*{1}={2} ", j, i, (j * i));  
                      Console.Write(t);  
                      //if (j * i < 82)  
                      //    Console.Write(" ");  
                      if (i == j)  
                          Console.Write("\n");  
                  }  
              }  
          }  
```

## 在1~10000的整数中，找出同时符合以下条件的数：a.必须是质数。b.该数字各位数字之和为偶数，如数字12345，各位数字之和为1+2+3+4+5=15，不是偶数。

> 本题考了两个地方：
> 
> （1）、质数的理解：质数就是所有比1大的整数中，除了1和它本身外，不再有别的约数。2是一个不是奇数的质数，它既是质数也是偶数，面试者极容易忽略这点。判断数N是否为质数要直接从3开始判断（如果N不是2），首先不能是偶数，然后再判断是否能被3、5、7....整除，直到sqrt(N)止。
> 
> （2）、求各位数字之和，可以通过循环取余的办法。

```C#
 using System;  
    using System.Collections.Generic;  

    class program  
    {  
       static void Mian(string[] args)  
       {  
          int N =1000;  
          List<int> primes = new List<int>();  
          primes.Add(2);  
          Console.Write(2+" ");  
          for(int i=3;i<N,i+=2)  
          {  
              if(!)  

          }  
       }  
       static bool IsDigitSumEven(int n)  
       {  
          int sum=0;  
          while(n>0)  
         {  
             sum +=n% 10;  
             n /=10;  
         }  
         return sum%2==0;  
       }  
    }  
```

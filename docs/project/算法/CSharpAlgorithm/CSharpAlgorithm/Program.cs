using System;

namespace CSharpAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            var getListData = ListSetAlgorithm.GetAfterRemoveListData();
            foreach (var itemValue in getListData)
            {
                Console.WriteLine(itemValue);
            }
       
            Console.WriteLine("Hello World!");
        }
    }
}

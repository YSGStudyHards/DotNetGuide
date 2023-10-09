namespace HelloDotNetGuide.常见算法
{
    public class List集合相关算法
    {
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
    }
}

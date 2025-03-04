namespace HelloDotNetGuide.CSharp语法
{
    public class DictionaryExercise
    {
        public static void DictionaryOperation()
        {
            //创建一个Dictionary来存储学生学号ID和姓名
            Dictionary<int, string> studentDic = new Dictionary<int, string>();

            #region 添加元素

            // Add方法（键必须唯一）
            studentDic.Add(1, "大姚");
            studentDic.Add(2, "小袁");
            studentDic.Add(3, "Edwin");

            // 索引器语法（键不存在时添加，存在时更新）
            studentDic[4] = "Charlie";
            studentDic[5] = "追逐时光者";

            // 安全添加（避免异常）
            bool isAdded = studentDic.TryAdd(6, "小明"); // 返回 false，因键已存在

            #endregion

            #region 访问元素

            // 直接访问（键必须存在，否则会有异常）
            var currentUserName = studentDic[1];
            Console.WriteLine($"当前学生姓名: {currentUserName}");

            // 安全访问（避免异常）
            if (studentDic.TryGetValue(5, out var getUserName))
            {
                Console.WriteLine($"UserName：{getUserName}");
            }
            else
            {
                Console.WriteLine("当前学生ID不存在");
            }

            #endregion

            #region

            // 修改元素
            studentDic[2] = "大西瓜";

            Console.WriteLine($"修改后的名称：{studentDic[2]}");

            #endregion

            #region 删除元素

            // 删除元素
            bool isRemoved = studentDic.Remove(3);

            Console.WriteLine($"删除结果：{isRemoved}");

            #endregion

            #region 检查键或值是否存在

            // 检查键是否存在
            if (studentDic.ContainsKey(1))
            {
                Console.WriteLine("存在");
            }
            else
            {
                Console.WriteLine("不存在");
            }

            bool isExistcontainsValue = studentDic.ContainsValue("追逐时光者");

            Console.WriteLine($"是否存在：{isExistcontainsValue}");


            #endregion

            #region 遍历元素

            // 遍历元素
            foreach (KeyValuePair<int, string> student in studentDic)
            {
                Console.WriteLine($"ID: {student.Key}, Name: {student.Value}");
            }

            // 使用键的枚举器
            foreach (var key in studentDic.Keys)
            {
                Console.WriteLine($"Key: {key}, Value: {studentDic[key]}");
            }

            // 使用值的枚举器
            foreach (var value in studentDic.Values)
            {
                // 注意：这种方式不能直接获取键，只能获取值
                Console.WriteLine($"Value: {value}");
            }

            #endregion
        }
    }
}

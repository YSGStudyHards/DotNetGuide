using static HelloDotNetGuide.CSharp语法.LinqExercise;

namespace HelloDotNetGuide.CSharp语法
{
    public class LinqExercise
    {
        #region .NET 9 中 LINQ 新增的功能

        public static void CountByExample()
        {
            var sourceText = "This is a test text. This is only a test. This is the best. This，This，This";

            // 统计每个单词出现的次数
            KeyValuePair<string, int> mostFrequentWord = sourceText
            .Split([' ', '.', ','], StringSplitOptions.RemoveEmptyEntries)
            .Select(word => word.ToLowerInvariant())
            .CountBy(word => word)
            .MaxBy(pair => pair.Value);

            Console.WriteLine($"最常见的词是：'{mostFrequentWord.Key}' 出现次数： {mostFrequentWord.Value}");
        }

        public static void AggregateByExample()
        {
            (string id, int score)[] data =
                [
                ("0", 88),
                ("1", 5),
                ("2", 4),
                ("1", 10),
                ("6", 5),
                ("4", 10),
                ("6", 25)];

            // aggregatedData 是一个序列，包含按姓名分组并计算总分的元素
            var aggregatedData =
                data.AggregateBy(
                    keySelector: entry => entry.id,
                    seed: 0,
                    (totalScore, curr) => totalScore + curr.score
                    );

            foreach (var item in aggregatedData)
            {
                Console.WriteLine(item);
            }
        }

        public static void IndexExample()
        {
            var lines = new List<string> { "First line", "Second line", "Third line" };
            foreach (var (index, line) in lines.Index())
            {
                Console.WriteLine($"Line {index + 1}: {line}");
            }
        }

        #endregion

        #region LINQ中常用方法

        public class StudentInfo
        {
            public int StudentID { get; set; }
            public string StudentName { get; set; }
            public DateTime Birthday { get; set; }
            public int ClassID { get; set; }
            public string Address { get; set; }
            public List<Course> Courses { get; set; } = new List<Course>();
        }

        public class Course
        {
            public int CourseID { get; set; }
            public string CourseName { get; set; }
        }

        static List<Course> courses = new List<Course>()
        {
           new Course
           {
             CourseID =  101,
             CourseName = "语文"
           },
           new Course
           {
             CourseID =  102,
             CourseName = "数学"
           },
           new Course
           {
             CourseID =  103,
             CourseName = "地理"
           },
           new Course
           {
             CourseID =  104,
             CourseName = "历史"
           }
        };

        static List<StudentInfo> students = new List<StudentInfo>
        {
            new StudentInfo
            {
                StudentID=1,
                StudentName="大姚",
                Birthday=Convert.ToDateTime("1997-10-25"),
                ClassID=101,
                Courses = new List<Course>
                {
                    new Course { CourseID = 101, CourseName = "语文" },
                    new Course { CourseID = 102, CourseName = "数学" }
                }
            },
            new StudentInfo
            {
                StudentID=2,
                StudentName="李四",
                Birthday=Convert.ToDateTime("1998-10-25"),
                ClassID=101,
                Courses = new List<Course>
                {
                    new Course { CourseID = 101, CourseName = "语文" },
                    new Course { CourseID = 102, CourseName = "数学" }
                }
            },
            new StudentInfo
            {
                StudentID=3,
                StudentName="王五",
                Birthday=Convert.ToDateTime("1999-10-25"),
                ClassID=102,
                Address="广州",
                Courses = new List<Course>
                {
                    new Course { CourseID = 101, CourseName = "语文" },
                    new Course { CourseID = 102, CourseName = "数学" }
                }
            },
            new StudentInfo
            {
                StudentID=4,
                StudentName="时光者",
                Birthday=Convert.ToDateTime("1999-11-25"),
                ClassID=102,
                Address="深圳" ,
                Courses = new List<Course>
                {
                    new Course { CourseID = 104, CourseName = "历史" },
                    new Course { CourseID = 103, CourseName = "地理" }
                }
            }
        };

        public static void CommonMethodsInLINQ()
        {
            #region 基本查询方法

            var femaleStudents = students.Where(s => s.StudentName == "追逐时光者");
            var studentNames = students.Select(s => s.StudentName);

            // 使用SelectMany展平所有学生的课程列表
            // SelectMany用于将多个集合（嵌套集合，如集合的集合）`展平`为一个集合。
            var allCourses = students.SelectMany(student => student.Courses).ToList();

            // 输出所有课程的名称
            foreach (var course in allCourses)
            {
                Console.WriteLine(course.CourseName);
            }

            #endregion

            #region 转换方法

            var studentList = students.ToList();
            var studentArray = students.ToArray();
            var studentDictionary = students.ToDictionary(s => s.StudentID, s => s.StudentName);
            var studentLookup = students.ToLookup(s => s.ClassID, s => s.StudentName);

            #endregion

            #region 元素操作方法

            var firstStudent = students.First();
            var firstAdult = students.FirstOrDefault(s => s.Birthday <= DateTime.Now.AddYears(-18));
            var onlyWangWu = students.Single(s => s.StudentName == "王五");
            var wangWuOrDefault = students.SingleOrDefault(s => s.StudentName == "王六");
            var lastStudent = students.Last();
            var lastAdult = students.LastOrDefault(s => s.Birthday <= DateTime.Now.AddYears(-18));
            var secondStudent = students.ElementAt(1);
            var tenthStudentOrDefault = students.ElementAtOrDefault(9);
            var nonEmptyStudents = students.DefaultIfEmpty(new StudentInfo { StudentID = 0, StudentName = "默认Student", Address = "默认" });

            #endregion

            #region 排序方法

            var sortedByBirthdayAsc = students.OrderBy(s => s.Birthday);
            var sortedByClassIDDesc = students.OrderByDescending(s => s.ClassID);
            var sortedByNameThenClassID = students.OrderBy(s => s.StudentName).ThenBy(s => s.ClassID);
            var sortedThenByDescending = students.OrderBy(s => s.StudentName).ThenBy(s => s.ClassID).ThenByDescending(x => x.Birthday);

            #endregion

            #region 聚合方法

            int studentCount = students.Count();
            int totalClassID = students.Sum(s => s.ClassID);
            double averageAge = students.Average(s => DateTime.Now.Year - s.Birthday.Year);
            int minClassID = students.Min(s => s.ClassID);
            int maxClassID = students.Max(s => s.ClassID);
            string concatenatedNames = students.Aggregate("", (acc, s) => acc == "" ? s.StudentName : acc + ", " + s.StudentName);

            #endregion

            #region 集合操作方法

            var uniqueClassIDs = students.Select(s => s.ClassID).Distinct();//
            var unionClassIDs = uniqueClassIDs.Union(new[] { 103, 104 });
            var intersectClassIDs = uniqueClassIDs.Intersect(new[] { 101, 103 });
            var exceptClassIDs = uniqueClassIDs.Except(new[] { 101 });
            var concatClassIDs = uniqueClassIDs.Concat(new[] { 103, 104 });

            #endregion

            #region 分组与连接方法

            var groupedByClassID = students.GroupBy(s => s.ClassID);

            foreach (var group in groupedByClassID)
            {
                Console.WriteLine($"班级ID: {group.Key}");
                foreach (var student in group)
                {
                    Console.WriteLine($"  学生姓名: {student.StudentName}");
                }
            }

            // 连接两个集合（内连接查询）
            var otherStudent = new List<StudentInfo>
            {
               new StudentInfo
               {
                   StudentID=4,
                   StudentName="摇一摇",
                   Birthday=Convert.ToDateTime("1997-10-25"),
                   ClassID=101,
                   Courses = new List<Course>
                   {
                       new Course { CourseID = 101, CourseName = "语文" },
                       new Course { CourseID = 102, CourseName = "数学" }
                   }
               }
            };

            var listJoin = students.Join(
                otherStudent, // 要连接的第二个集合
                s1 => s1.StudentID, // 从第一个集合中提取键
                s2 => s2.StudentID, // 从第二个集合中提取键
                (s1, s2) => new // 结果选择器，指定如何从两个匹配元素创建结果
                {
                    StudentID = s1.StudentID,
                    StudentName = s1.StudentName,
                    Birthday = s1.Birthday,
                    ClassID = s1.ClassID,
                    Address = s1.Address,
                    Courses = s1.Courses,
                    OtherStudentName = s2.StudentName
                });

            //使用 GroupJoin 方法实现两个集合的左连接（Left Join）
            //目标：获取所有课程及选修学生（即使无人选修也要显示课程）
            var courseStudentGroups = courses.GroupJoin(
                students.SelectMany(
                    student => student.Courses,
                    (student, course) => new { Student = student, Course = course }
                ),
                course => course.CourseID,
                studentCoursePair => studentCoursePair.Course.CourseID,
                // 结果投影：生成课程名称及对应的学生列表
                (course, matchedStudents) => new
                {
                    CourseName = course.CourseName,
                    Students = matchedStudents
                        .Select(pair => pair.Student.StudentName)
                        .DefaultIfEmpty("（无学生）")
                        .ToList()
                }
            ).ToList();

            // 输出结果
            foreach (var group in courseStudentGroups)
            {
                Console.WriteLine("-------------------");
                Console.WriteLine($"课程：{group.CourseName}");
                Console.WriteLine($"选修学生：{string.Join(", ", group.Students)}");
                Console.WriteLine("-------------------");
            }

            #endregion

            #region 跳过与获取指定数量的元素

            var skippedStudents = students.Skip(1);
            var takenStudents = students.Take(2);

            //数据分页查询（Skip + Take）
            int pageNumber = 2;
            int pageSize = 10;
            var pagedUsers = skippedStudents
                .OrderBy(u => u.ClassID) // 必须排序
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            #endregion

            #region 条件判断方法

            bool allAdults = students.All(s => s.Birthday <= DateTime.Now.AddYears(-18));
            bool anyAdults = students.Any(s => s.Birthday <= DateTime.Now.AddYears(-18));
            bool containsWangWu = students.Contains(students.First(s => s.StudentName == "王五"));

            #endregion

            #region 使用查询语法

            var querySyntaxResult = from student in students
                                    where student.ClassID == 101
                                    orderby student.StudentName ascending
                                    select student;

            Console.WriteLine("查询语法结果:");
            foreach (var student in querySyntaxResult)
            {
                Console.WriteLine($"{student.StudentName}, ClassID: {student.ClassID}");
            }

            #endregion

            #region 使用方法语法

            var methodSyntaxResult = students
                                    .Where(student => student.ClassID == 101)
                                    .OrderBy(student => student.StudentName)
                                    .ToList();


            Console.WriteLine("方法语法结果:");
            foreach (var student in methodSyntaxResult)
            {
                Console.WriteLine($"{student.StudentName}, ClassID: {student.ClassID}");
            }

            #endregion

            #region 混合查询和方法语法

            var mixedResult = (from student in students
                               where student.ClassID == 101
                               where student.Courses.Any(course => course.CourseName == "数学")
                               orderby student.StudentName ascending
                               select student)
                       .Take(2)
                       .ToList();

            // 输出结果
            Console.WriteLine("混合查询结果:");
            foreach (var student in mixedResult)
            {
                Console.WriteLine($"{student.StudentName}, ClassID: {student.ClassID}");
            }

            #endregion
        }

        #endregion

        #region ToDictionary 和 ToLookup

        public static void ToDictionaryExamples()
        {
            var employeeList = new List<Employee>
            {
                new Employee { Id = 101, Name = "大姚", Department = "研发部", Salary = 15000, Age = 28, City = "北京" },
                new Employee { Id = 102, Name = "小米", Department = "研发部", Salary = 18000, Age = 32, City = "上海" },
                new Employee { Id = 103, Name = "王敏", Department = "销售部", Salary = 12000, Age = 26, City = "北京" }
                // 如需演示重复键，可解除下面注释
                //new Employee { Id = 103, Name = "王敏", Department = "销售部", Salary = 12000, Age = 26, City = "北京" }
            };

            // 最基础：键=Id，值=元素本身
            // 如果存在重复 Id，会在此抛 System.ArgumentException:“An item with the same key has already been added. Key: 103”
            Dictionary<int, Employee> dict1 = employeeList.ToDictionary(e => e.Id);

            //System.Collections.Generic.KeyNotFoundException:“The given key '999' was not present in the dictionary.”
            //var queryData = dict1[999];

            // 安全取值方式：TryGetValue 避免 KeyNotFoundException
            if (dict1.TryGetValue(101, out var emp101))
            {
                Console.WriteLine($"找到员工 101：{emp101.Name}");
            }
            else
            {
                Console.WriteLine("未找到员工 101");
            }

            //值修改
            dict1[101].Name = "大姚修改名称";

            // 指定键选择器 + 值选择器
            Dictionary<int, string> dict2 = employeeList.ToDictionary(
                e => e.Id,     // 键：Id
                e => e.Name    // 值：姓名
            );

            // 指定比较器（如不区分大小写的姓名作为键）
            var dictByNameIgnoreCase = employeeList.ToDictionary(
                e => e.Name,
                e => e,
                StringComparer.OrdinalIgnoreCase);//不区分大小写

            // 防重复键写法：先 GroupBy 再取 First()
            // 若源数据可能有重复 Id，用此方式避免抛异常
            var dictMerged = employeeList
                .GroupBy(e => e.Id)
                .ToDictionary(
                    g => g.Key,
                    g => g.First()  // 或自定义合并逻辑
                );
        }

        public static void ToLookupExamples()
        {
            var employeeList = new List<Employee>
            {
                new Employee { Id = 101, Name = "大姚", Department = "研发部", Salary = 15000, Age = 28, City = "北京" },
                new Employee { Id = 102, Name = "小米", Department = "研发部", Salary = 18000, Age = 32, City = "上海" },
                new Employee { Id = 103, Name = "王敏", Department = "销售部", Salary = 12000, Age = 26, City = "北京" },
                new Employee { Id = 101, Name = "大姚", Department = "研发部", Salary = 15000, Age = 28, City = "北京" },
                new Employee { Id = 102, Name = "小米", Department = "研发部", Salary = 18000, Age = 32, City = "上海" },
                new Employee { Id = 103, Name = "王敏", Department = "销售部", Salary = 12000, Age = 26, City = "北京" }
            };

            // ToLookup：天然一对多分组；键重复不会抛异常
            var lookupByDept = employeeList.ToLookup(
                e => e.Department, // 键：部门
                e => e             // 值：元素本身（可省略，默认元素本身）
            );

            var lookupById = employeeList.ToLookup(
                e => e.Id, // 键：部门
                e => e             // 值：元素本身（可省略，默认元素本身）
            );

            // 访问：查不到键时返回空序列，不抛异常
            foreach (var emp in lookupByDept["研发部"])
            {
                Console.WriteLine($"研发部成员：{emp.Name}");
            }

            // 查一个不存在的键，不会抛异常，只是 foreach 不会进入
            foreach (var emp in lookupByDept["不存在的部门"])
            {
                // 不会执行
            }

            // ToLookup 也可指定比较器
            var lookupByCityIgnoreCase = employeeList.ToLookup(
                e => e.City,
                e => e.Name,
                StringComparer.OrdinalIgnoreCase);//不区分大小写
        }

        #endregion

        #region SelectMany 和 Select

        /// <summary>
        /// 演示 SelectMany 和 Select 方法的区别与用法
        /// </summary>
        public static void SelectManyAndSelectExamples()
        {
            var students = new List<StudentInfo>
            {
                new StudentInfo
                {
                    StudentID=1,
                    StudentName="大姚",
                    Courses = new List<Course>
                    {
                        new Course { CourseID = 101, CourseName = "语文" },
                        new Course { CourseID = 102, CourseName = "数学" }
                    }
                },
                new StudentInfo
                {
                    StudentID=2,
                    StudentName="李四",
                    Courses = new List<Course>
                    {
                        new Course { CourseID = 101, CourseName = "语文" },
                        new Course { CourseID = 103, CourseName = "地理" }
                    }
                }
            };

            // 使用 SelectMany 展平课程列表（去重可加 Distinct()）
            var allCourses = students.SelectMany(student => student.Courses).ToList();
            Console.WriteLine("使用 SelectMany 展平课程列表:");
            foreach (var course in allCourses)
            {
                Console.WriteLine(course.CourseName);
            }

            // 使用 Select 获取嵌套的课程列表
            var nestedCourses = students.Select(student => student.Courses).ToList();
            Console.WriteLine("使用 Select 获取嵌套的课程列表:");
            foreach (var courseList in nestedCourses)
            {
                Console.WriteLine("课程列表:");
                foreach (var course in courseList)
                {
                    Console.WriteLine(course.CourseName);
                }
            }

            var nestedLists = new List<List<int>>
            {
                new List<int> { 1, 2 },
                new List<int> { 3, 4, 5 },
                new List<int> { 6,7,8,9,10 }
            };

            var flattened = nestedLists.SelectMany(x => x).ToList();

            //  输出结果: [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
            Console.WriteLine(string.Join(", ", flattened));
        }

        /// <summary>
        /// SelectMany 字符串处理
        /// </summary>
        public static void StringProcessingExample()
        {
            var sentences = new List<string>
            {
                "Hello world",
                "LINQ is powerful",
                "SelectMany flattens"
            };

            var words = sentences
                .SelectMany(sentence => sentence.Split(' '))
                .Where(word => !string.IsNullOrEmpty(word))
                .ToList();

            // 拆分句子为单词
            // 输出结果: Hello, world, LINQ, is, powerful, SelectMany, flattens
            Console.WriteLine(string.Join(", ", words));
        }

        /// <summary>
        /// SelectMany 生成笛卡尔积(慎用大集合)
        /// </summary>
        public static void CartesianProductExample()
        {
            var numbers = new[] { 1, 2, 3, 4 };
            var letters = new[] { "A", "B", "G", "Y" };

            // 所有 (number, letter) 组合
            var combinations = numbers
                .SelectMany(
                    num => letters,
                    (num, letter) => $"{num}{letter}"
                )
                .ToList();

            // 输出结果: 1A, 1B, 1G, 1Y, 2A, 2B, 2G, 2Y, 3A, 3B, 3G, 3Y, 4A, 4B, 4G, 4Y
            Console.WriteLine(string.Join(", ", combinations));
        }

        #endregion
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
}

# 🐮C#/.NET/.NET Core学习，面试指南(每周一更🌋)
> 概述：发现网上关于Java、前端、Android...等相关技术的学习资料，面试指南一搜都是一大把的，但是我们大.NET的相关学习资料，面试指南和一些常见的面试题都是寥寥无几，并不是没有人写，而是因为资料和学习技术点太零散了，缺少一个汇总的知识库。因此作为.NET开发中的一员当然是不想让这种现象普遍存在啦，建立这个知识库的初衷就是为了收集、汇总、总结网上优秀的.NET相关学习资料和常见的面试题以及自己的一些微薄的见解供大家参考学习，同时由衷的希望大家可以在Issues中投稿一起完善我们的.NET学习，面试的知识库。

🙌知识库中有总结不足的地方，欢迎各位大佬给我提意见([💖留下您宝贵的建议][21])。
如果这个知识库对大家有帮助的话记得给作者一个星星哟⭐! 

[21]:https://github.com/YSGStudyHards/DotNetGuide/issues/7


## 🔍目录(善用Ctrl+F)

## 🏷️C#/.NET/.NET Core高质量教程收录栈
### [⚒️开发利器][21]
  [21]:https://github.com/YSGStudyHards/DotNetGuide/issues/11
### 🔋[awesome-dotnet-core][9]
   [9]:https://github.com/jasonhua95/awesome-dotnet-core
### 📚[C#/.NET/.NET Core推荐学习书籍][20]
   [20]:https://github.com/YSGStudyHards/DotNetGuide/issues/9
### 🐮[C#/.NET/.NET Core推荐博客or博主][12]
   [12]:https://github.com/YSGStudyHards/DotNetGuide/issues/8
### 🏗️[C#/.NET/.NET Core优秀项目，框架汇总 ][7]
   [7]:https://github.com/YSGStudyHards/DotNetGuide/issues/5
### 📚[2021年 ASP.NET Core 开发者学习指南（中文）][4]
  [4]:https://github.com/MoienTajik/AspNetCore-Developer-Roadmap/blob/master/ReadMe.zh-Hans.md
### ⛵[C#/.NET/.NET Core推荐学习路线，文档，文章][19]
   [19]:https://github.com/YSGStudyHards/DotNetGuide/issues/10
### 📚[C# 指南（微软提供的最权威，最全面的C#学习资料）][1]
  [1]: https://docs.microsoft.com/zh-cn/dotnet/csharp/
### 📚[.NET 文档（微软提供的最权威，最全面的.NET学习资料）][3]
  [3]:https://docs.microsoft.com/zh-cn/dotnet/


---


## ✍️C#/.NET/.NET Core基础
*  [.NET 中所有类的基类][5]
   >Object

   [5]: https://docs.microsoft.com/zh-cn/dotnet/api/system.object?view=netcore-3.1
   
*  [C#中类和结构的基本概念][8]
   > 类和结构是 .NET通用类型系统的两种基本构造。每种本质上都是一种数据结构，其中封装了同属一个逻辑单元的一组数据和行为。 数据和行为是类或结构的成员，包括字段、方法、属性、索引器、运算符和事件等。
  
  [8]:https://docs.microsoft.com/zh-cn/dotnet/csharp/programming-guide/classes-and-structs/
   
- C#支持的访问修饰符
    - public：共有的，访问不受限制；
    - private：私有的，只能在当前类中访问；
    - internal：内部的，只能在当前程序集中访问；
    - protected：受保护的，只能在当前类或其派生类中访问；
    - protected  internal：受保护的内部成员，当前程序集或派生自包含类的类型可访问；
    - private protected：私有受保护的成员，当前程序集中的包含类或从包含类派生的类型可访问；

*  C#类和结构默认访问修饰符
   > Internal
   
*  C#适用于类和结构访问修饰符有哪些
   > public 或 internal

*  类成员和结构成员的默认访问修饰符为
   > private

*  结构成员（包括嵌套的类和结构）可以声明为
   > public、internal 或 private   注意：结构成员无法声明为 protected、protected internal 或 private protected，因为结构不支持继承。
   
*  类成员（包括嵌套的类和结构）可以声明为
   > public、protected internal、protected、internal、private protected 或 private

*  [C#类成员包括][9]
   >字段、常量、属性、方法、事件、运算符、索引器、构造函数、终结器、嵌套类型

[9]:https://docs.microsoft.com/zh-cn/dotnet/csharp/programming-guide/classes-and-structs/members

*  派生类不能具有高于其基类型的可访问性

*  描述类和对象的区别
   >类（class）指一类事物，对象（object）指属于这一类事物的实体。类定义了对象的相关数据和方法，类可以通过构造函数生成对象，对象实现了类的定义，且用于具体的数据。

*  [C#面向对象编程之使用代码描述类和对象的区别][10]

[10]:https://www.cnblogs.com/Can-daydayup/p/13894227.html

* [走进C# abstract，了解抽象类与接口的异同][18]

[18]:https://www.cnblogs.com/Can-daydayup/p/13676586.html

---


## 🧱设计模式
### 作用：
> 设计模式（Design Pattern） 是一套被反复使用、多数人知晓的、经过分类编目的、代码设计经验的总结，使用设计模式是为了可重用代码、让代码更容易被他人理解并且保证代码可靠性。

*  [免费在线学习代码重构和设计模式][13]

   [13]:https://refactoringguru.cn/

*  [设计模式之禅（第2版）][16]

   [16]:https://www.kancloud.cn/sstd521/design/193489
   
   
*  [大话设计模式][17]

   [17]:http://www.ddooo.com/softdown/109592.htm

*  [C#常见的23种设计模式（含源码）圣杰][14]

   [14]:https://github.com/sheng-jie/Design-Pattern

*  [23种面向对象设计模式示例代码（C#实现,含源码，EdisonChou）][15]

   [15]:https://github.com/EdisonChou/DesignPattern.Samples.CSharp



---


## 🧮算法


---


## 🍇非NoSQL数据库


---


## 🍉NoSQL数据库
















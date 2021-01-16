# 🐮C#/.NET/.NET Core学习、工作、面试指南（让自己不再迷漫✨）
> 概述：发现网上关于Java、前端、Android...等相关技术的学习资料，面试指南一搜都是一大把的，但是我们大.NET的相关学习资料，面试指南和一些常见的面试题都是寥寥无几，并不是没有人写，而是因为网上的资料和文章太零散了，缺少一个汇总的知识库。因此作为.NET开发中的一员当然是不想让这种现象普遍存在啦，建立这个知识库的初衷就是为了收集、汇总、总结网上优秀的.NET相关学习资料和常见的面试题以及自己的一些微薄的见解供大家参考学习，并且还会有一些面试时需要注意的事项供大家参考。同时由衷的希望大家可以在Issues中投稿一起完善我们的.NET学习，面试的知识库。

🙌知识库中有总结不足的地方，欢迎各位大佬给我提意见([💖留下您宝贵的建议](https://github.com/YSGStudyHards/DotNetGuide/issues/7))。
如果这个知识库对大家有帮助的话记得给作者一个星星哟⭐! 


> 点击下面的图片，前往Issues留下您收集的宝藏👇：

[![宝藏收集地](http://ysgdaydayup.gitee.io/my-picture-bed/SourceMaterial/GithubPicture/GithubIssues.png "宝藏收集地")](https://github.com/YSGStudyHards/DotNetGuide/issues)


## 🔍目录(善用Ctrl+F)
* [🏷️C#/.NET/.NET Core高质量教程收录栈]()
* [✍️C#/.NET/.NET Core基础]()
---

## 🏷️C#/.NET/.NET Core高质量教程收录栈
### [⚒️开发利器](https://github.com/YSGStudyHards/DotNetGuide/issues/11)
### 🔋[awesome-dotnet-core](https://github.com/jasonhua95/awesome-dotnet-core)
### 📚[C#/.NET/.NET Core推荐学习书籍](https://github.com/YSGStudyHards/DotNetGuide/issues/9)
### 🐮[C#/.NET/.NET Core推荐博客or博主](https://github.com/YSGStudyHards/DotNetGuide/issues/8)
### 🏗️[C#/.NET/.NET Core优秀项目，框架汇总 ](https://github.com/YSGStudyHards/DotNetGuide/issues/5)
### 📚[2021年 ASP.NET Core 开发者学习指南（中文）](https://github.com/MoienTajik/AspNetCore-Developer-Roadmap/blob/master/ReadMe.zh-Hans.md)
### ⛵[C#/.NET/.NET Core推荐学习路线，文档，文章](https://github.com/YSGStudyHards/DotNetGuide/issues/10)
### 📚[C# 指南（微软提供的最权威，最全面的C#学习资料）](https://docs.microsoft.com/zh-cn/dotnet/csharp/)
### 📚[.NET 文档（微软提供的最权威，最全面的.NET学习资料）](https://docs.microsoft.com/zh-cn/dotnet/)
### 🔎[面向开发人员和技术专业人员的Microsoft文档和学习主页](https://docs.microsoft.com/zh-cn/)

---


## ✍️C#/.NET/.NET Core基础
*  [.NET 中所有类的基类](https://docs.microsoft.com/zh-cn/dotnet/api/system.object?view=netcore-3.1)
   >Object
   
*  [C#中类和结构的基本概念](https://docs.microsoft.com/zh-cn/dotnet/csharp/programming-guide/classes-and-structs/)
   > 类和结构是 .NET通用类型系统的两种基本构造。每种本质上都是一种数据结构，其中封装了同属一个逻辑单元的一组数据和行为。 数据和行为是类或结构的成员，包括字段、方法、属性、索引器、运算符和事件等。
   
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

*  [C#类成员包括](https://docs.microsoft.com/zh-cn/dotnet/csharp/programming-guide/classes-and-structs/members)
   >字段、常量、属性、方法、事件、运算符、索引器、构造函数、终结器、嵌套类型

*  派生类不能具有高于其基类型的可访问性

*  描述类和对象的区别
   >类（class）指一类事物，对象（object）指属于这一类事物的实体。类定义了对象的相关数据和方法，类可以通过构造函数生成对象，对象实现了类的定义，且用于具体的数据。
* [C#面向对象编程之使用代码描述类和对象的区别](https://www.cnblogs.com/Can-daydayup/p/13894227.html)
* [走进C# abstract，了解抽象类与接口的异同](https://www.cnblogs.com/Can-daydayup/p/13676586.html)

---


## 🧱设计模式
### 作用：
> 设计模式（Design Pattern） 是一套被反复使用、多数人知晓的、经过分类编目的、代码设计经验的总结，使用设计模式是为了可重用代码、让代码更容易被他人理解并且保证代码可靠性。

* [免费在线学习代码重构和设计模式](https://refactoringguru.cn/)
* [设计模式之禅（第2版）](https://www.kancloud.cn/sstd521/design/193489)
* [大话设计模式](http://www.ddooo.com/softdown/109592.htm)
* [C#常见的23种设计模式（含源码）圣杰](https://github.com/sheng-jie/Design-Pattern)
* [23种面向对象设计模式示例代码（C#实现,含源码，EdisonChou）](https://github.com/EdisonChou/DesignPattern.Samples.CSharp)
* [图说设计模式](https://github.com/me115/design_patterns)
* [史上最全设计模式导学目录](http://blog.csdn.net/lovelion/article/details/17517213)
* [design pattern 包教不包会](https://github.com/AlfredTheBest/Design-Pattern)


---


## 🧮算法
* [在线算法刷题平台-力扣（LeetCode）](https://leetcode-cn.com/)
* [labuladong 的算法小抄](https://labuladong.gitbook.io/algo/)
* [小浩算法](https://www.geekxh.com/0.0.%E5%AD%A6%E4%B9%A0%E9%A1%BB%E7%9F%A5/01.html)
* [C#冒泡法排序算法]
* [C#快速排序算法]
* [C#二分查找算法]
---


## 🍇关系型数据库
### [关系型数据库是什么？](http://c.biancheng.net/view/6490.html)
### MySQL
* [MySQL 教程](https://www.runoob.com/mysql/mysql-tutorial.html)
* [MySQL 入门教程](https://www.w3cschool.cn/mysql/mysql-tutorial.html)
* [MySQL索引背后的数据结构及算法原理](http://blog.codinglabs.org/articles/theory-of-mysql-index.html)
* [21分钟MySQL入门教程](http://www.cnblogs.com/mr-wid/archive/2013/05/09/3068229.html)
* [顺丰面试：MySQL十连击](https://mp.weixin.qq.com/s/ZoCZLG3o3AZBDSO1y3nbmw)
* [MySQL中，21个写SQL的好习惯](https://mp.weixin.qq.com/s/cAJg_MZP_xI853wLdWAE7A)

### Microsoft SQL Server
* [Microsoft SQL 文档](https://docs.microsoft.com/zh-cn/sql/?view=sql-server-ver15)

### PostgreSQL
* [PostgreSQL 教程](https://www.runoob.com/postgresql/postgresql-tutorial.html)
* [PostgreSQL 11.2 手册](http://www.postgres.cn/docs/11/)

---


## 🍉NoSQL数据库
### [NoSQL数据库有哪些？](http://c.biancheng.net/view/6498.html)
### Redis
* [Redis中文文档](https://www.redis.com.cn/documentation.html)
* [Redis 设计与实现](http://redisbook.com/)
* [Redis 命令参考](http://redisdoc.com/)
* [带有详细注释的 Redis 3.0 代码](https://github.com/huangz1990/redis-3.0-annotated)
* [带有详细注释的 Redis 2.6 代码](https://github.com/huangz1990/annotated_redis_source)
* [Redis知识点总结](https://github.com/CyC2018/CS-Notes/blob/master/notes/Redis.md)
* [面试前必须要知道的Redis面试题](https://mp.weixin.qq.com/s?__biz=MzI4Njg5MDA5NA==&mid=2247484609&idx=1&sn=4c053236699fde3c2db1241ab497487b&chksm=ebd745c0dca0ccd682e91938fc30fa947df1385b06d6ae9bb52514967b0736c66684db2f1ac9###rd)

### MongoDB
* [MongoDB教程：1天玩转MongoDB数据库](http://c.biancheng.net/mongodb/)

### Memcached
* [Memcached入门教程](http://c.biancheng.net/view/6498.html)

---

## 💡 系统设计
* [Microservices from Design to Deployment 中文版 《微服务：从设计到部署》](https://github.com/DocsHome/microservices)
* [秒杀系统设计与实现](https://github.com/qiurunze123/miaosha)
* [系统与架构设计](https://github.com/zaiyunduan123/Java-Summarize/blob/master/notes/scene/Scene-Design.md)

---

## 💻 操作系统，代理服务器
* [计算机操作系统](https://github.com/CyC2018/CS-Notes/blob/master/notes/%E8%AE%A1%E7%AE%97%E6%9C%BA%E6%93%8D%E4%BD%9C%E7%B3%BB%E7%BB%9F%20-%20%E7%9B%AE%E5%BD%95.md)
* [Linux](https://github.com/YSGStudyHards/DotNetGuide/blob/main/docs/Linux/Linux.md)

---

## 🙇 面试须知
* [写简历的技巧](https://github.com/atian25/blog/issues/3)
* [程序员简历模板系列](https://github.com/geekcompany/ResumeSample)
* [程序员应该有的一些好习惯+面试必知事项](https://github.com/Snailclimb/programmer-advancement#%E5%A4%9A%E7%94%A8-github)
* [大厂面试,面试官看了直呼想要的简历](https://www.cnblogs.com/aobing/p/12117044.html)

---

## 🧭 宝藏指南
* [免费的计算机编程类中文书籍](https://github.com/YSGStudyHards/free-programming-books-zh_CN)
* [架构师技术图谱，助你早日成为架构师](https://github.com/toutiaoio/awesome-architecture)
* [中国独立开发者项目列表 -- 分享大家都在做什么](https://github.com/YSGStudyHards/chinese-independent-developer)

---

## ✈️ 社区组织
* [Organizations Ranking](https://gitstar-ranking.com/organizations)
* [Microsoft](https://github.com/microsoft)
* [ASP.NET](https://github.com/aspnet)
* [.NET Core Community](https://github.com/dotnetcore)
* [新生命开发团队](https://github.com/NewLifeX)




# 🐮C#/.NET/.NET Core学习、工作、面试指南（让现在的自己不再迷茫✨）
> 概述：发现现如今网上关于Java、前端、Android、Golang...等相关技术的学习资料，面试指南一搜都是一大把，但是我们大.NET/C#的相关学习资料，面试指南和一些常见的面试题都是寥寥无几，并不是没有人写，而是因为网上的资料和文章太零散了，缺少一个汇总的知识库。因此作为.NET开发中的一员当然是不想让这种现象普遍存在啦，建立这个知识库的初衷就是为了收集、汇总、总结网上优秀的.NET相关学习资料和常见的面试题以及自己在学习和工作中的一些微薄的见解供大家参考学习，并且还会有一些面试时需要注意的事项供大家参考。同时由衷的希望大家可以在Issues中投稿或者直接提交PR一起完善我们.NET学习、工作、面试指南知识库。

🙌知识库中有总结不足的地方，欢迎各位大佬给我提意见([💖留下您宝贵的建议](https://github.com/YSGStudyHards/DotNetGuide/issues/7))。
如果这个知识库对大家有帮助的话记得给作者一个星星哟⭐(您的小星星就是对我最大的肯定和鼓励)！


> 点击下面的图片，前往Issues留下您压箱底的大宝藏👇：

[![宝藏收集地](https://images.cnblogs.com/cnblogs_com/Can-daydayup/2138171/o_221031161905_QQ%E5%9B%BE%E7%89%8720221101001913.png "宝藏收集地")](https://github.com/YSGStudyHards/DotNetGuide/issues)

**🤝欢迎关注我一起沟通、交流学习、共同进步（💯关注后回复【1】加入DotNetGuide技术交流微信群，回复其他关键字获取更多.NET相关学习资料）。**

![追逐时光者公众号自动回复内容](https://images.cnblogs.com/cnblogs_com/Can-daydayup/2145481/o_221105055539_%E5%85%AC%E4%BC%97%E5%8F%B7%E5%9B%9E%E5%A4%8D.jpg)

![追逐时光者的微信公众号](https://images.cnblogs.com/cnblogs_com/Can-daydayup/2141413/o_220409130943_%E6%88%91%E7%9A%84%E5%85%AC%E4%BC%97%E5%8F%B7.jpg "追逐时光者的微信公众号")


## 🔍目录(善用Ctrl+F)
* [🏷️C#/.NET/.NET Core高质量教程收录栈](https://github.com/YSGStudyHards/DotNetGuide#%EF%B8%8Fcnetnet-core%E9%AB%98%E8%B4%A8%E9%87%8F%E6%95%99%E7%A8%8B%E6%94%B6%E5%BD%95%E6%A0%88)
* [🎁C#/.NET/.NET Core面试宝典](https://github.com/YSGStudyHards/DotNetGuide#cnetnet-core%E9%9D%A2%E8%AF%95%E5%AE%9D%E5%85%B8)
* [🥇C#/.NET/.NET Core开发实战教程](https://github.com/YSGStudyHards/DotNetGuide#cnetnet-core%E5%BC%80%E5%8F%91%E5%AE%9E%E6%88%98%E6%95%99%E7%A8%8B)
* [🧱设计模式](https://github.com/YSGStudyHards/DotNetGuide#%E8%AE%BE%E8%AE%A1%E6%A8%A1%E5%BC%8F)
* [🧮算法](https://github.com/YSGStudyHards/DotNetGuide#%E7%AE%97%E6%B3%95)
* [🍇关系型数据库（SQL）](https://github.com/YSGStudyHards/DotNetGuide#%E5%85%B3%E7%B3%BB%E5%9E%8B%E6%95%B0%E6%8D%AE%E5%BA%93sql)
* [🍉非关系型数据库（NoSQL）](https://github.com/YSGStudyHards/DotNetGuide#%E9%9D%9E%E5%85%B3%E7%B3%BB%E5%9E%8B%E6%95%B0%E6%8D%AE%E5%BA%93nosql)
* [💡系统设计](https://github.com/YSGStudyHards/DotNetGuide#%E7%B3%BB%E7%BB%9F%E8%AE%BE%E8%AE%A1)
* [💻操作系统](https://github.com/YSGStudyHards/DotNetGuide#%E6%93%8D%E4%BD%9C%E7%B3%BB%E7%BB%9F)
* [🛰️网络相关](https://github.com/YSGStudyHards/DotNetGuide#%EF%B8%8F%E7%BD%91%E7%BB%9C%E7%9B%B8%E5%85%B3)
* [☁️容器技术](https://github.com/YSGStudyHards/DotNetGuide#%EF%B8%8F%E5%AE%B9%E5%99%A8%E6%8A%80%E6%9C%AF)
* [🧰DevOps、CI&CD自动化工具](https://github.com/YSGStudyHards/DotNetGuide#devopscicd%E8%87%AA%E5%8A%A8%E5%8C%96%E5%B7%A5%E5%85%B7)
* [🌍Web前端相关](https://github.com/YSGStudyHards/DotNetGuide#web%E5%89%8D%E7%AB%AF%E7%9B%B8%E5%85%B3)
* [🧲版本控制工具](https://github.com/YSGStudyHards/DotNetGuide#%E7%89%88%E6%9C%AC%E6%8E%A7%E5%88%B6%E5%B7%A5%E5%85%B7)
* [🙇面试须知](https://github.com/YSGStudyHards/DotNetGuide#%E9%9D%A2%E8%AF%95%E9%A1%BB%E7%9F%A5)
* [👩‍💻程序员简历模板](https://github.com/YSGStudyHards/DotNetGuide/blob/main/README.md#%E7%A8%8B%E5%BA%8F%E5%91%98%E7%AE%80%E5%8E%86%E6%A8%A1%E6%9D%BF)
* [🧭宝藏指南](https://github.com/YSGStudyHards/DotNetGuide#%E5%AE%9D%E8%97%8F%E6%8C%87%E5%8D%97)
* [✈️社区组织](https://github.com/YSGStudyHards/DotNetGuide#%EF%B8%8F%E7%A4%BE%E5%8C%BA%E7%BB%84%E7%BB%87)

---



## 🏷️C#/.NET/.NET Core高质量教程收录栈
### ⚒️[开发利器](https://github.com/YSGStudyHards/DotNetGuide/issues/11)
### 🔋[awesome-dotnet-core](https://github.com/jasonhua95/awesome-dotnet-core)
### 🥇[高质量付费学习课程推荐](https://www.yuque.com/ysgstudyhard/da6e0c/nkoqf7)
### 📚[.NET应用程序体系结构文档](https://docs.microsoft.com/zh-cn/dotnet/architecture/)
### 📰[C#/.NET/.NET Core最新资讯](https://github.com/YSGStudyHards/DotNetGuide/issues/16)
### 📚[C#/.NET/.NET Core推荐学习书籍](https://github.com/YSGStudyHards/DotNetGuide/issues/9)
### 📺[C#/.NET/.NET Core学习视频汇总](https://www.cnblogs.com/Can-daydayup/p/15046838.html)
### 🐮[C#/.NET/.NET Core推荐博客or博主](https://github.com/YSGStudyHards/DotNetGuide/issues/8)
### 🚤[值得推荐的.NET/.NET Core ORM框架汇总](https://www.cnblogs.com/Can-daydayup/p/15911410.html)
### 🏗️[C#/.NET/.NET Core优秀项目，框架汇总](https://github.com/YSGStudyHards/DotNetGuide/issues/5)
### 📚[2022年 ASP.NET Core 开发者学习指南（中文）](https://github.com/MoienTajik/AspNetCore-Developer-Roadmap/blob/master/ReadMe.zh-Hans.md)
### ⛵[C#/.NET/.NET Core推荐学习路线，文档，文章](https://github.com/YSGStudyHards/DotNetGuide/issues/10)
### 📚[C# 指南（微软提供的最权威，最全面的C#学习资料）](https://docs.microsoft.com/zh-cn/dotnet/csharp/)
### 📚[.NET 文档（微软提供的最权威，最全面的.NET学习资料）](https://docs.microsoft.com/zh-cn/dotnet/)
### 🔎[面向开发人员和技术专业人员的Microsoft文档和学习主页](https://docs.microsoft.com/zh-cn/)

#### 🔝[返回目录](https://github.com/YSGStudyHards/DotNetGuide#%E7%9B%AE%E5%BD%95%E5%96%84%E7%94%A8ctrlf)
---



## 🎁C#/.NET/.NET Core面试宝典
面试宝典地址：[https://www.yuque.com/ysgstudyhard/da6e0c👉](https://www.yuque.com/ysgstudyhard/da6e0c)
> 因为个人的能力和精力有限没法把涉及的所有知识点都总结归纳（现在主要是对一些常见的知识点进行了总结和归纳），希望有更多的小伙伴能加入和我一起完善这方面的相关知识点。对知识库有贡献者可获得更多学习资源。

**🐱‍🚀C#/.NET/.NET Core常见面试题汇总，不仅仅为了面试而学习，更多的是查漏补缺、扩充知识面和大家共同学习进步。**

![追逐时光者](https://images.cnblogs.com/cnblogs_com/Can-daydayup/2145479/o_221031161923_QQ%E5%9B%BE%E7%89%8720221101001736.png)

#### 🔝[返回目录](https://github.com/YSGStudyHards/DotNetGuide#%E7%9B%AE%E5%BD%95%E5%96%84%E7%94%A8ctrlf)
---

## 🥇C#/.NET/.NET Core开发实战教程
### .NET MongoDB从入门到实战的教程
- [MongoDB从入门到实战之MongoDB简介👉](https://www.cnblogs.com/Can-daydayup/p/16797608.html)
- [MongoDB从入门到实战之MongoDB快速入门👉](https://www.cnblogs.com/Can-daydayup/p/16804415.html)
- [MongoDB从入门到实战之Docker快速安装MongoDB👉](https://www.cnblogs.com/Can-daydayup/p/16838976.html)
- [MongoDB从入门到实战之MongoDB工作常用操作命令👉](https://www.cnblogs.com/Can-daydayup/p/16840085.html)
- [MongoDB从入门到实战之.NET Core使用MongoDB开发ToDoList系统（1）-后端项目框架搭建👉](https://www.cnblogs.com/Can-daydayup/p/17020707.html)
- [MongoDB从入门到实战之.NET Core使用MongoDB开发ToDoList系统（2）-Swagger框架集成👉](https://www.cnblogs.com/Can-daydayup/p/17020885.html)
- [MongoDB从入门到实战之.NET Core使用MongoDB开发ToDoList系统（3）-系统数据集合设计👉](https://www.cnblogs.com/Can-daydayup/p/17033785.html)
- [MongoDB从入门到实战之.NET Core使用MongoDB开发ToDoList系统（4）-MongoDB数据仓储封装👉](https://www.cnblogs.com/Can-daydayup/p/17157135.html)



#### 🔝[返回目录](https://github.com/YSGStudyHards/DotNetGuide#%E7%9B%AE%E5%BD%95%E5%96%84%E7%94%A8ctrlf)
---


## 🧱设计模式
### 作用：
> 设计模式（Design Pattern） 是一套被反复使用、多数人知晓的、经过分类编目的、代码设计经验的总结，使用设计模式是为了可重用代码、让代码更容易被他人理解并且保证代码可靠性。
> 面向对象结合设计模式，才能真正体会到程序变得可维护、可复用、可扩展、灵活性好。设计模式对于程序员而言并不陌生，每个程序员在编程时都会或多或少地接触到设计模式。无论是在大型程序的架构中，亦或是在源码的学习中，设计模式都扮演着非常重要的角色。

* [大话设计模式](http://www.ddooo.com/softdown/109592.htm)
* [图说设计模式](https://github.com/me115/design_patterns)
* [设计模式之禅（第2版）](https://www.kancloud.cn/sstd521/design/193489)
* [史上最全设计模式导学目录](http://blog.csdn.net/lovelion/article/details/17517213)
* [design pattern 包教不包会](https://github.com/AlfredTheBest/Design-Pattern)
* [免费在线学习代码重构和设计模式](https://refactoringguru.cn/)
* [C#常见的23种设计模式（含源码）圣杰](https://github.com/sheng-jie/Design-Pattern)
* [23种面向对象设计模式示例代码（C#实现,含源码，EdisonChou）](https://github.com/EdisonChou/DesignPattern.Samples.CSharp)

#### 🔝[返回目录](https://github.com/YSGStudyHards/DotNetGuide#%E7%9B%AE%E5%BD%95%E5%96%84%E7%94%A8ctrlf)
---



## 🧮算法
* [小浩算法](https://www.geekxh.com/0.0.%E5%AD%A6%E4%B9%A0%E9%A1%BB%E7%9F%A5/01.html)
* [CodeTop企业题库](https://codetop.cc/home)
* [labuladong 的算法小抄](https://labuladong.gitee.io/algo/)
* [在线算法刷题平台-力扣（LeetCode)](https://leetcode-cn.com/)
* [C#冒泡法排序算法](http://c.biancheng.net/view/2854.html)
* C#快速排序算法
  * [C#快速排序算法基础入门篇](https://www.cnblogs.com/csdbfans/p/3541044.html)
  * [C#排序算法之快速排序](https://www.jianshu.com/p/db020fa7130a)
* [C#递归排序算法](https://blog.51cto.com/tonyqus/1154618)
* [C#二分查找算法](https://lovejy.blog.csdn.net/article/details/81844237?spm=1001.2101.3001.6650.1&utm_medium=distribute.pc_relevant.none-task-blog-2%7Edefault%7EOPENSEARCH%7Edefault-1.opensearchhbase&depth_1-utm_source=distribute.pc_relevant.none-task-blog-2%7Edefault%7EOPENSEARCH%7Edefault-1.opensearchhbase)
* [C#经典算法面试题汇总](https://github.com/YSGStudyHards/DotNetGuide/blob/main/docs/project/%E7%AE%97%E6%B3%95/C%23%E7%BB%8F%E5%85%B8%E7%AE%97%E6%B3%95%E9%9D%A2%E8%AF%95%E9%A2%98.md)


#### 🔝[返回目录](https://github.com/YSGStudyHards/DotNetGuide#%E7%9B%AE%E5%BD%95%E5%96%84%E7%94%A8ctrlf)
---



## 🍇关系型数据库（SQL）
> 关系型数据库指的是使用关系模型（二维表格模型）来组织数据的数据库。

## SQL和数据库相关
* [数据库系统原理](http://www.cyc2018.xyz/%E6%95%B0%E6%8D%AE%E5%BA%93/%E6%95%B0%E6%8D%AE%E5%BA%93%E7%B3%BB%E7%BB%9F%E5%8E%9F%E7%90%86.html#%E4%B8%80%E3%80%81%E4%BA%8B%E5%8A%A1)
* [关系型数据库是什么？](http://c.biancheng.net/view/6490.html)
* [自学SQL网](http://xuesql.cn/)
* [牛客网在线SQL练习](https://www.nowcoder.com/exam/oj?tab=SQL%E7%AF%87&topicId=199)
* [非关系型数据库（NOSQL）和关系型数据库（SQL）区别详解](https://www.cnblogs.com/Can-daydayup/p/14353082.html)

### MySQL
* [MySQL教程](https://www.runoob.com/mysql/mysql-tutorial.html)
* [SQL语法基础](http://www.cyc2018.xyz/%E6%95%B0%E6%8D%AE%E5%BA%93/SQL%20%E8%AF%AD%E6%B3%95.html#%E4%B8%80%E3%80%81%E5%9F%BA%E7%A1%80)
* [MySQL入门教程](https://www.w3cschool.cn/mysql/mysql-tutorial.html)
* [MySQL知识汇总](https://www.cnblogs.com/Gao-yubo/p/15525872.html)
* [MySQL基础知识汇总](http://www.cyc2018.xyz/%E6%95%B0%E6%8D%AE%E5%BA%93/MySQL.html#%E4%B8%80%E3%80%81%E7%B4%A2%E5%BC%95)
* [21分钟MySQL入门教程](http://www.cnblogs.com/mr-wid/archive/2013/05/09/3068229.html)
* [顺丰面试：MySQL十连击](https://mp.weixin.qq.com/s/ZoCZLG3o3AZBDSO1y3nbmw)
* [MySQL中，21个写SQL的好习惯](https://mp.weixin.qq.com/s/cAJg_MZP_xI853wLdWAE7A)
* [MySQL夺命16问，你能回答出几个？](https://mp.weixin.qq.com/s/eJepG60ll0gaEPVb1IAKVA)
* [MySQL入门教程（MySQL tutorial book）](https://github.com/jaywcjlove/mysql-tutorial)
* [MySQL索引背后的数据结构及算法原理](http://blog.codinglabs.org/articles/theory-of-mysql-index.html)

### Microsoft SQL Server
* [SQL Server教程](https://www.w3cschool.cn/sqlserver/sqlserver-1p6728kn.html)
* [SQL Server 技术文档](https://docs.microsoft.com/zh-cn/sql/sql-server/?view=sql-server-ver15)
* [Microsoft SQL 文档](https://docs.microsoft.com/zh-cn/sql/?view=sql-server-ver15)
* [SQL Server文章目录](https://www.cnblogs.com/CareySon/archive/2012/05/08/2489748.html)
* [SSMS管理工具快速入门](https://docs.microsoft.com/zh-cn/sql/ssms/quickstarts/ssms-connect-query-sql-server?view=sql-server-ver15)

### PostgreSQL
* [PostgreSQL 教程](https://www.runoob.com/postgresql/postgresql-tutorial.html)
* [PostgreSQL中文文档](http://www.postgres.cn/v2/document)
* [PostgreSQL 11.2 手册](http://www.postgres.cn/docs/11/)
* [PostgreSQL 12.2 手册](http://www.postgres.cn/docs/12/)

### Oracle
* [Oracle入门教程](https://www.w3cschool.cn/oraclejc/)
* [Oracle基础教程](https://www.oraclejsq.com/article/010100110.html)
* [Oracle快速入门视频教程](https://www.bilibili.com/video/BV1u54y1G7xq?spm_id_from=333.337.search-card.all.click)

#### 🔝[返回目录](https://github.com/YSGStudyHards/DotNetGuide#%E7%9B%AE%E5%BD%95%E5%96%84%E7%94%A8ctrlf)
---



## 🍉非关系型数据库（NoSQL）
> 非关系型数据库又被称为 NoSQL（Not Only SQL )，意为不仅仅是 SQL。通常指数据以对象的形式存储在数据库中，而对象之间的关系通过每个对象自身的属性来决定，常用于存储非结构化的数据。

### NoSQL相关概念
* [NoSQL数据库有哪些？](http://c.biancheng.net/view/6498.html)

### Redis
* [Redis中文文档](https://www.redis.com.cn/documentation.html)
* [Redis 设计与实现](http://redisbook.com/)
* [Redis 命令参考](http://redisdoc.com/)
* [Redis基础知识汇总](http://www.cyc2018.xyz/%E6%95%B0%E6%8D%AE%E5%BA%93/Redis.html#%E4%B8%80%E3%80%81%E6%A6%82%E8%BF%B0)
* [带有详细注释的 Redis 2.6 代码](https://github.com/huangz1990/annotated_redis_source)
* [带有详细注释的 Redis 3.0 代码](https://github.com/huangz1990/redis-3.0-annotated)
* [面试前必须要知道的Redis面试题](https://mp.weixin.qq.com/s?__biz=MzI4Njg5MDA5NA==&mid=2247484609&idx=1&sn=4c053236699fde3c2db1241ab497487b&chksm=ebd745c0dca0ccd682e91938fc30fa947df1385b06d6ae9bb52514967b0736c66684db2f1ac9###rd)

### MongoDB
* [MongoDB中文社区](https://mongoing.com/)
* [MongoDB官方手册](https://docs.mongodb.com/manual/)
* [MongoDB教程：1天玩转MongoDB数据库](http://c.biancheng.net/mongodb/)
* [MongoDB高频面试题](https://mongoing.com/archives/docs/mongodb%e5%88%9d%e5%ad%a6%e8%80%85%e6%95%99%e7%a8%8b/mongodb%e9%ab%98%e9%a2%91%e9%9d%a2%e8%af%95%e9%a2%98)
* [95道MongoDB面试题详解](https://developer.aliyun.com/article/764824)
* [MongoDB安全加固，防止数据库攻击删除勒索威胁](https://www.cnblogs.com/Can-daydayup/p/16970210.html)

### Memcached
* [Memcached入门教程](https://www.runoob.com/memcached/memcached-tutorial.html)
* [Memcached视频教程_免费Memcached教程在线学习](https://www.php.cn/course/list/55.html)

#### 🔝[返回目录](https://github.com/YSGStudyHards/DotNetGuide#%E7%9B%AE%E5%BD%95%E5%96%84%E7%94%A8ctrlf)
---



## 💡系统设计
* [系统设计入门](https://github.com/donnemartin/system-design-primer)
* [微服务：从设计到部署](https://github.com/DocsHome/microservices)
* [秒杀系统设计与实现](https://github.com/qiurunze123/miaosha)
* [系统与架构设计](https://github.com/zaiyunduan123/Java-Summarize/blob/master/notes/scene/Scene-Design.md)

#### 🔝[返回目录](https://github.com/YSGStudyHards/DotNetGuide#%E7%9B%AE%E5%BD%95%E5%96%84%E7%94%A8ctrlf)
---



## 💻操作系统
* [王道计算机考研 操作系统视频教程](https://www.bilibili.com/video/BV1YE411D7nH?from=search&seid=13464543417132613798&spm_id_from=333.337.0.0)
* [计算机操作系统](https://github.com/CyC2018/CS-Notes/blob/master/notes/%E8%AE%A1%E7%AE%97%E6%9C%BA%E6%93%8D%E4%BD%9C%E7%B3%BB%E7%BB%9F%20-%20%E7%9B%AE%E5%BD%95.md)
* [Linux](https://github.com/YSGStudyHards/DotNetGuide/blob/main/docs/Linux/Linux.md)


#### 🔝[返回目录](https://github.com/YSGStudyHards/DotNetGuide#%E7%9B%AE%E5%BD%95%E5%96%84%E7%94%A8ctrlf)
---



## 🛰️网络相关
* [计算机网络](http://www.cyc2018.xyz/%E8%AE%A1%E7%AE%97%E6%9C%BA%E5%9F%BA%E7%A1%80/%E7%BD%91%E7%BB%9C%E5%9F%BA%E7%A1%80/%E8%AE%A1%E7%AE%97%E6%9C%BA%E7%BD%91%E7%BB%9C%20-%20%E7%9B%AE%E5%BD%95.html#%E5%8F%82%E8%80%83%E9%93%BE%E6%8E%A5)
* [HTTP](http://www.cyc2018.xyz/%E8%AE%A1%E7%AE%97%E6%9C%BA%E5%9F%BA%E7%A1%80/HTTP/HTTP.html#%E4%B8%80-%E3%80%81%E5%9F%BA%E7%A1%80%E6%A6%82%E5%BF%B5)
* [Socket](http://www.cyc2018.xyz/%E8%AE%A1%E7%AE%97%E6%9C%BA%E5%9F%BA%E7%A1%80/Socket/Socket.html#%E4%B8%80%E3%80%81i-o-%E6%A8%A1%E5%9E%8B)
* [TCP和UDP的区别](https://zhuanlan.zhihu.com/p/24860273)
* [什么是RPC？](https://www.jianshu.com/p/7d6853140e13)

#### 🔝[返回目录](https://github.com/YSGStudyHards/DotNetGuide#%E7%9B%AE%E5%BD%95%E5%96%84%E7%94%A8ctrlf)

---



## ☁️容器技术
### Kubernetes（K8s）
> Kubernetes是容器集群管理系统，是一个开源的平台，可以实现容器集群的自动化部署、自动扩缩容、维护等功能。

* [一文了解 Kubernetes](https://zhuanlan.zhihu.com/p/162928436)
* [Kubernetes（K8S）是什么?](https://www.cnblogs.com/Can-daydayup/p/16706198.html)
* [Kubernetes(K8s) 解决了哪些问题？](https://www.zhihu.com/question/329365548/answer/1545488275)
* [Kubernetes中文社区](https://www.kubernetes.org.cn/)



### Docker
> Docker是一个开源的应用容器引擎，基于Golang 语言开发，可以让开发者打包他们的应用以及依赖包到一个轻量级、可移植的容器中，然后发布到任何流行的 Linux 服务器。容器是一个沙箱机制，相互之间不会有影响（类似于我们手机上运行的 app），并且容器开销是很低的。Docker 是一个供开发人员和系统管理员构建、运行和与容器共享应用程序的平台。使用容器部署应用程序称为容器化。容器并不是新事物，但它们用于轻松部署应用程序却是新鲜的。 

* [什么是Docker？](https://zhuanlan.zhihu.com/p/187505981)
* [Docker官方文档教程](https://docs.docker.com/)
* [Docker中文社区](https://www.docker.org.cn/)
* [全面的Docker快速入门教程](https://www.cnblogs.com/Can-daydayup/p/15559341.html)
* [Docker — 从入门到实践](https://vuepress.mirror.docker-practice.com/)
* [Docker日常工作常用命令](https://www.cnblogs.com/Can-daydayup/p/16456586.html)
* [十本你不容错过的Docker入门到精通书籍推荐](https://www.cnblogs.com/Can-daydayup/p/15585714.html)
* [CentOS 8.4安装Docker](https://www.cnblogs.com/Can-daydayup/p/15395980.html)
* [Ubuntu 20.04安装Docker](https://www.cnblogs.com/Can-daydayup/p/16472375.html)
* [Windows10 Docker安装详细教程](https://www.cnblogs.com/Can-daydayup/p/15468591.html)
* [Docker安装MySQL并使用Navicat连接 ](https://www.cnblogs.com/Can-daydayup/p/16653879.html)
* [Docker安装Redis并使用Another Redis Desktop Manager连接](https://www.cnblogs.com/Can-daydayup/p/16653903.html)
* [Docker安装MongoDB并使用Navicat连接](https://www.cnblogs.com/Can-daydayup/p/16653882.html)


### 服务编排
- [Kubernetes](https://kubernetes.io/)
- [Docker Swarm](https://docs.docker.com/engine/swarm)
- [Mesos](https://mesos-cn.gitbooks.io/mesos-cn/content/OverView/Mesos-Architecture.html)

#### 🔝[返回目录](https://github.com/YSGStudyHards/DotNetGuide#%E7%9B%AE%E5%BD%95%E5%96%84%E7%94%A8ctrlf)
---



## 🧰DevOps、CI&CD自动化工具
### DevOps
> DevOps（英文Development和Operations的组合）是一组过程、方法与系统的统称，用于促进开发（应用程序/软件工程）、技术运营和质量保障（QA）部门之间的沟通、协作与整合。它的出现是由于软件行业日益清晰地认识到：为了按时交付软件产品和服务，开发和运营工作必须紧密合作。

* [DevOps到底是什么意思？](https://zhuanlan.zhihu.com/p/91371659)
* [DevOps，CI，CD，自动化简单介绍](https://www.cnblogs.com/Can-daydayup/p/14274932.html)
* [2021年25佳DevOps工具](https://www.kubernetes.org.cn/9538.html)

### CI&CD构建、部署、自动化工具
* [21个自动化部署工具](https://zhuanlan.zhihu.com/p/248508683)
* [7个CI / CD(持续集成和持续部署)工具](https://cloud.tencent.com/developer/article/1346876)
* 常用持续集成与部署工具
  - [Jenkins](https://www.jenkins.io/)
  - [Github Actions](https://github.com/features/actions)
  - [Azure Pipelines](https://azure.microsoft.com/zh-cn/services/devops/pipelines/)
  - [Travis CI](https://travis-ci.org/)
  - [Circle CI](https://circleci.com/)
  - [TeamCity](https://www.jetbrains.com/teamcity)

> 越来越多的工程团队正在采用敏捷开发，推动更短，更快的发布周期。代码库增长和创建新生产构建的频率导致[持续集成](https://cloud.tencent.com/product/coding-ci?from=10680)和[持续部署](https://cloud.tencent.com/product/coding-cd?from=10680)/交付工具的兴起。

#### 🔝[返回目录](https://github.com/YSGStudyHards/DotNetGuide#%E7%9B%AE%E5%BD%95%E5%96%84%E7%94%A8ctrlf)
---



## 🌍Web前端相关
### Web前端自学面试宝典

* [Vue官网](https://v3.cn.vuejs.org/)
* [大前端面试宝典](https://lucifer.ren/fe-interview/#/?id=大前端面试宝典-图解前端)
* [大圣编程自学网](https://shengxinjing.cn/)
* [前端学习路线图](https://github.com/CurrentVastStars/front-end-roadmap)
* [前端进阶之道](https://yuchengkai.cn/)
* [千古前端图文教程](https://web.qianguyihao.com/#%E5%89%8D%E8%A8%80)
* [前端3+1面试题库](https://github.com/haizlin/fe-interview)
* [HTML/CSS菜鸟教程](https://www.runoob.com/)
* [GitHub最全的前端资源汇总仓库](https://github.com/FrontEndGitHub/FrontEndGitHub)

### Web前端常见面试题

* [HTTP1.0、HTTP1.1 和 HTTP2.0 的区别](https://mp.weixin.qq.com/s/GICbiyJpINrHZ41u_4zT-A)
* HTTP响应状态码
  * 1xx：指示信息--表示请求已接收，继续处理。
  * 2xx：成功--表示请求已被成功接收、理解、接受。
  * 3xx：重定向--要完成请求必须进行更进一步的操作。
  * 4xx：客户端错误--请求有语法错误或请求无法实现。
  * 5xx：服务器端错误--服务器未能实现合法的请求。
* [TCP/IP协议详解](https://zhuanlan.zhihu.com/p/33889997)
* [经典面试题：在浏览器地址栏输入一个URL后回车，背后发生了什么?](https://www.cnblogs.com/cswiki/p/14429730.html)
* [最新前端面试中常见的面试题（附答案）](https://blog.csdn.net/Jet_Lover/article/details/115637795)
* [中高级前端大厂面试秘籍，为你保驾护航金三银四，直通大厂(上)](https://juejin.cn/post/6844903776512393224)
* [面试分享：两年工作经验成功面试阿里P6总结](https://juejin.cn/post/6844903928442667015)
* [写给女朋友的中级前端面试秘籍（含详细答案，15k级别）](https://juejin.cn/post/6844904115428917255)
* [中高级前端面试-JavaScript手写代码无敌秘籍](https://juejin.cn/post/6844903809206976520)


#### 🔝[返回目录](https://github.com/YSGStudyHards/DotNetGuide#%E7%9B%AE%E5%BD%95%E5%96%84%E7%94%A8ctrlf)
---



## 🧲版本控制工具
### Git
* [Git简明指南](https://rogerdudler.github.io/git-guide/index.zh.html)
* [Git的奇技淫巧](https://github.com/521xueweihan/git-tips)
* [Git参考手册](http://gitref.justjavac.com/)
* [猴子都能懂的Git入门](http://backlogtool.com/git-guide/cn/)
* [Git教程-廖雪峰](https://www.liaoxuefeng.com/wiki/896043488029600)
* [Git的奇技淫巧](https://github.com/521xueweihan/git-tips#git-%E7%9A%84%E5%A5%87%E6%8A%80%E6%B7%AB%E5%B7%A7see_no_evil)
* [最全面SourceTree使用教程详解](https://www.cnblogs.com/Can-daydayup/p/13128633.html)
* [VS Code使用Git可视化管理源代码详细教程](https://www.cnblogs.com/Can-daydayup/p/14413914.html)

### SVN
* [Subversion版本控制](https://svnbook.red-bean.com/nightly/zh/index.html)
* [SVN教程-菜鸟教程](https://www.runoob.com/svn/svn-tutorial.html)
* [SVN版本控制软件视频教程](https://www.bilibili.com/video/BV1mW411M7yR?p=5)



#### 🔝[返回目录](https://github.com/YSGStudyHards/DotNetGuide#%E7%9B%AE%E5%BD%95%E5%96%84%E7%94%A8ctrlf)
---

## 🙇面试须知
* [写简历的技巧](https://github.com/atian25/blog/issues/3)
* [技术面试最后反问面试官的话](https://github.com/yifeikong/reverse-interview-zh)
* [程序员应该有的一些好习惯+面试必知事项](https://github.com/Snailclimb/programmer-advancement#%E5%A4%9A%E7%94%A8-github)
* [大厂面试,面试官看了直呼想要的简历](https://www.cnblogs.com/aobing/p/12117044.html)
* [面试常见的10个问题(成功率高达90%的回答技巧)](https://mp.weixin.qq.com/s/VxL7Lr_FCr37gJu_vGZNCw)

#### 🔝[返回目录](https://github.com/YSGStudyHards/DotNetGuide#%E7%9B%AE%E5%BD%95%E5%96%84%E7%94%A8ctrlf)
---

## 👩‍💻程序员简历模板

| 项目描述 | 项目地址 |
| --- | --- |
| Resume template for Chinese programmers：程序员简历模板系列。包括PHP程序员简历模板、iOS程序员简历模板、Android程序员简历模板、Web前端程序员简历模板、Java程序员简历模板、C/C++程序员简历模板、NodeJS程序员简历模板、架构师简历模板以及通用程序员简历模板 | [https://github.com/geekcompany/ResumeSample](https://github.com/geekcompany/ResumeSample) |
| Markdown-Resume：用 markdown 语法来写的简历模版，非常简结通用 | [https://github.com/CyC2018/Markdown-Resume](https://github.com/CyC2018/Markdown-Resume) |
| awesome-resume：程序员简历例句，程序员简历范例 | [https://github.com/resumejob/awesome-resume](https://github.com/resumejob/awesome-resume) |
| DeerResume：好用的MarkDown在线简历工具，可在线预览、编辑、设置访问密码和生成PDF | [https://github.com/geekcompany/DeerResume](https://github.com/geekcompany/DeerResume) |
| markdown-resume：在线简历排版工具，支持切换 4 种模版、自定义和导出功能[支持Markdown和富文本的在线简历排版工具]| [https://github.com/mdnice/markdown-resume](https://github.com/mdnice/markdown-resume) |
| best-resume-ever：快速轻松制作多份精美简历，打造您有史以来最好的简历！ 用Vue和LESS制作| [https://github.com/salomonelli/best-resume-ever](https://github.com/salomonelli/best-resume-ever) |
| awesome-resume-for-chinese：适合中文的简历模板收集 | [https://github.com/dyweb/awesome-resume-for-chinese](https://github.com/dyweb/awesome-resume-for-chinese) |
|resume：在线简历生成器|https://github.com/visiky/resume|


#### 🔝[返回目录](https://github.com/YSGStudyHards/DotNetGuide#%E7%9B%AE%E5%BD%95%E5%96%84%E7%94%A8ctrlf)
---


## 🧭宝藏指南

* [Markdown语法教程](https://markdown.com.cn/basic-syntax/)
* [免费的接口服务收集](https://github.com/fangzesheng/free-api)
* [免费的计算机编程类中文书籍](https://github.com/YSGStudyHards/free-programming-books-zh_CN)
* [编程电子书，电子书，编程书籍PDF免费地址](https://github.com/itdevbooks/pdf)
* [架构师技术图谱，助你早日成为架构师](https://github.com/toutiaoio/awesome-architecture)
* [中国独立开发者项目列表 -- 分享大家都在做什么](https://github.com/YSGStudyHards/chinese-independent-developer)
* [世界上最大的电子书图书馆（九百万本电子图书任你下载）](https://hk1lib.org/)
* [使用Typora+Docsify打造最强、最轻量级的个人&团队文档](https://github.com/YSGStudyHards/Docsify-Guide)

#### 🔝[返回目录](https://github.com/YSGStudyHards/DotNetGuide#%E7%9B%AE%E5%BD%95%E5%96%84%E7%94%A8ctrlf)
---



## ✈️社区组织
* [Organizations Ranking](https://gitstar-ranking.com/organizations)
* [ASP.NET](https://github.com/aspnet)
* [Microsoft](https://github.com/microsoft)
* [Microsoft Docs](https://github.com/MicrosoftDocs)
* [.NET Core Community](https://github.com/dotnetcore)
* [新生命开发团队](https://github.com/NewLifeX)
* [.NET Platform](https://github.com/dotnet)
* [App vNext](https://github.com/App-vNext)
* [dotNET China](https://gitee.com/dotnetchina)
* [.NET Application Architecture](https://github.com/dotnet-architecture)

#### 🔝[返回目录](https://github.com/YSGStudyHards/DotNetGuide#%E7%9B%AE%E5%BD%95%E5%96%84%E7%94%A8ctrlf)



𓆌𓆉𓆈𓃻𓄿𓅜𓃹𓆉𓆈𓃻𓄿𓅜𓆌𓆉𓆈𓃻𓄿𓅜𓃹𓆉𓃲𓃟𓃠𓃗𓃵𓆉𓇼𓆡𓆜𓆉𓃹𓃡𓃟𓃵𓆏𓅦𓄿𓅜𓆌𓆉𓆈𓃻𓄿𓅜𓆌𓆉𓆈𓃻𓄿𓅜𓃹𓆉𓆈𓃻𓄿𓅜𓆌𓆉𓆈𓃻𓄿𓅜𓃹𓆉𓃲𓃟𓃠𓃗𓃵𓆉𓇼𓆡𓆜𓆉𓃹𓃡𓃟𓃵𓆏𓅦𓄿𓅜𓆌𓆉




# C#/.NET/.NET Core技术前沿周刊

![C#/.NET/.NET Core技术前沿周刊图](https://images.cnblogs.com/cnblogs_com/Can-daydayup/2416946/o_240819141912_%E6%8A%80%E6%9C%AF%E5%89%8D%E6%B2%BF%E5%91%A8%E5%88%8A.png "C#/.NET/.NET Core技术前沿周刊图")

# 前言
C#/.NET/.NET Core技术前沿周刊，你的每周技术指南针！记录、追踪C#/.NET/.NET Core领域、生态的每周最新、最实用、最有价值的技术文章、社区动态、优质项目和学习资源等。让你时刻站在技术前沿，助力技术成长与视野拓宽。

> 欢迎投稿，推荐或自荐优质文章/项目/学习资源等。**每周一定期发布！！！**

- [📰C#/.NET/.NET Core技术前沿周刊汇总](https://github.com/YSGStudyHards/DotNetGuide/blob/main/docs/DotNet/DotNetWeekly.md)
- [🏆C#/.NET/.NET Core技术前沿周刊Issues](https://github.com/YSGStudyHards/DotNetGuide/issues/44)

# 推广平台
- [知乎](https://www.zhihu.com/column/c_1809214011323060225)
- [CSDN](https://blog.csdn.net/qq_37237487/category_12762708.html)
- [公众号](https://mp.weixin.qq.com/mp/appmsgalbum?__biz=MzIxMTUzNzM5Ng==&action=getalbum&album_id=3598502850881585160&scene=126&sessionid=-1990606076#wechat_redirect)
- [博客园](https://www.cnblogs.com/Can-daydayup/tag/%E3%80%90%E6%8A%80%E6%9C%AF%E5%89%8D%E6%B2%BF%E5%91%A8%E5%88%8A%E3%80%91/)

# 2024年
## 9月
### 第 4 期（2024年9.1-9.8）

## 8月
### 第 3 期（2024年8.26-8.31）
#### 发布.NET Aspire 8.2 – 告别组件，迎接集成！
- 文章简介：在 .NET Aspire 8.2 中，你会注意到的一个重大变化是 .NET Aspire 组件现在被称为“集成”！.NET Aspire 集成是一个包，你可以将其添加到应用程序中，以简化设置、启动和与主要云服务和平台通信的过程。
- 文章地址：https://devblogs.microsoft.com/dotnet/announcing-dotnet-aspire-8-2/

#### BinaryFormatter从.NET 9中移除
- 文章简介：从.NET 9开始，我们不再在运行时中包含BinaryFormatter的实现（.NET Framework保持不变）。API仍然存在，但它们的实现总是抛出异常，而不管项目类型如何。因此，设置现有的向后兼容性标志不再足以使用BinaryFormatter。
- 文章地址：https://devblogs.microsoft.com/dotnet/binaryformatter-removed-from-dotnet-9/

#### 介绍Pinecone .NET SDK
- 文章简介：Pinecone是一个强大的矢量数据库，旨在有效地处理和查询大规模矢量数据。有了Pinecone，工程师和数据科学家可以毫不费力地构建基于向量的AI应用程序，这些应用程序需要高效的相似性搜索和排名。
- 文章地址：https://devblogs.microsoft.com/dotnet/introducing-pinecone-dotnet-sdk/

#### .NET Community Toolkit 8.3来了！NativeAOT，.NET 8增强功能，以及更多！
- 文章简介：我们很高兴地宣布.NET社区工具包8.3版正式发布！这个新版本包括对所有库的.NET 8和NativeAOT支持，性能改进，一些错误修复和增强等等！
- 文章地址：https://devblogs.microsoft.com/dotnet/announcing-the-dotnet-community-toolkit-830/

#### C#开发工具包更新带来了增强的Razor智能感知，项目状态和新的配置选项
- 文章简介：开发人员最重要的要求之一是我们在C# Dev Kit中改进Razor IntelliSense和Razor错误管理，我们正在倾听。随着8月稳定版的发布，使用Razor文件变得更加顺畅。告别恼人的闪烁错误消息，欢迎改进的智能感知，帮助您更快，更自信地编码。
- 文章地址：https://devblogs.microsoft.com/dotnet/whats-new-in-csharp-dev-kit-august-2024/

#### 在.NET Core中灵活使用反射
- 文章简介：前段时间有朋友问道一个这样的问题，.NET Core中如何通过Attribute的元数据信息来调用标记的对应方法。我第一时间想到的就是通过C#反射获取带有Custom Attribute标记的类，然后通过依赖注入（DI）的方式获取对应服务的方法并通过反射动态执行类的方法，从而实现更灵活的编程方式。 
- 文章地址：https://mp.weixin.qq.com/s/dPwuPcdicO7gXGG4weWEOA

#### 再也不用为找.NET相关的项目和框架发愁了
- 文章简介：本文将告诉你找.NET相关的项目和框架可以优先看DotNetGuide的C#/.NET/.NET Core优秀项目和框架精选专栏，里面收录了大量的.NET相关的优秀项目和框架，当然假如你有更好的项目和框架推荐的欢迎PR投稿（让优秀的项目和框架不被埋没）。 
- 文章地址：https://mp.weixin.qq.com/s/Thrp3ONtuh13h-aD8Cs8sA

#### 使用asp.net core 8+vue3 实现高效音视频通话
- 文章简介：在三年前，写智能小车的时候，当时小车上有一个摄像头需要采集，实现推拉流的操作，技术选型当时第一版用的是nginx的rtmp的推拉流，服务器的配置环境是centos，2H4G3M的一个配置，nginx的rtmp的延迟是20秒，超慢，后来研究了SRS以及ZLMediaKit这两个开源的推拉流服务器，没记错的话，两个都是基于c++开发的，性能都很棒，后来更换了推拉流服务器，小汽车的延迟在一秒不到，性能大幅度提升，当时研究了一下，然后没有记录，这次使用SRS实现了音视频通话，以及共享桌面的功能，特此记录以及分享给大家。
- 文章地址：https://www.cnblogs.com/1996-Chinese-Chen/p/18384394

#### Mono 现状与未来：从Wine-mono 到.NET 9
- 文章简介：Mono 官网主页和 Mono GitHub 页面今日发布公告，微软宣布将 Mono 项目移交给 WineHQ 组织，也就是 Linux 兼容 Windows 应用框架 Wine 的开发团队。
- 文章地址：https://www.cnblogs.com/shanyou/p/18385885

#### .NET 摄像头采集
- 文章简介：本文主要介绍摄像头（相机）如何采集数据，用于类似摄像头本地显示软件，以及流媒体数据传输场景如传屏、视讯会议等。摄像头采集有多种方案，如AForge.NET、WPFMediaKit、OpenCvSharp、EmguCv、DirectShow.NET、MediaCaptre（UWP），网上一些文章以及github已经有很多介绍，这里总结、确认技术选型给大家一个参考
- 文章地址：https://www.cnblogs.com/kybs0/p/18385599

#### 使用Visual Studio分析.NET Dump，快速查找程序内存泄漏问题！
- 文章简介：内存泄漏和高CPU使用率是在日常开发中经常遇到的问题，它们可能会导致应用程序性能下降甚至崩溃。今天我们来讲讲如何使用Visual Studio 2022分析.NET Dump，快速找到程序内存泄漏问题。
- 文章地址：https://mp.weixin.qq.com/s/EyIRGF7a6FkKGNYdKCvs4g

#### .NET9让指标更纯正
- 文章简介：Metrics为程序健康运行提供了保驾护航，但过多的指标又会为问题调查，大屏展示，以及基础日志存储带来更多的负担，特别对一些几乎没有意义的指示，比如健康检查的请求指标。.NET 9 引入了一个新功能，允许在某些端点和请求上选择不采集HTTP 指标记录。
- 文章地址：https://mp.weixin.qq.com/s/fw9rWMMraFp0Fcg4_PboFQ

#### 一个开源的C#/.NET宝藏级编程技巧练习库
- 文章简介：DotNetExercises是一个开源，免费的针对C#/.NET/.NET Core编程技巧的综合性练习库。 
- 文章地址：https://mp.weixin.qq.com/s/V24Q074iD6fZwyOzuu5mlg

### 第 2 期（2024年8.19-8.25）
#### 使用 MSTest.Analyzers 增强您的测试体验
- 文章简介：MSTest 附带了一组分析器，可以检查您的测试代码并指出常见错误和陷阱。这些错误可能很微妙，并导致您的测试被测试框架完全忽略。
- 文章地址：https://devblogs.microsoft.com/dotnet/supercharge-your-testing-experience-with-ms-test-analyzers/

#### Visual Studio 2022 v17.11新的调试和诊断功能
- 文章简介：调试和诊断对于任何开发人员来说都是至关重要的技能，但要精通它们也可能很困难且耗时。因此，我们在 Visual Studio 2022 v17.11 中添加了一些出色的新功能和增强功能，以帮助您比以往更快、更轻松地查找和解决错误。以下
- 文章地址：https://devblogs.microsoft.com/visualstudio/new-debugging-and-diagnostic-features/

#### .NET 智能组件简介 – AI 支持的 UI 控件
- 文章简介：人工智能的新进展有望彻底改变我们与软件交互和使用软件的方式。但将人工智能功能添加到现有软件中可能具有挑战性。这就是我们构建新的 .NET 智能组件的原因，这是一组真正有用的人工智能驱动的 UI 组件，您可以快速轻松地添加到 .NET 应用程序中。您不必花费数周的开发时间来重新设计用户体验或研究机器学习和提示工程。 .NET 智能组件是预构建的端到端 AI 功能，您可以将其放入现有的应用程序 UI 中，以提高用户的工作效率。
- 文章地址： https://devblogs.microsoft.com/dotnet/introducing-dotnet-smart-components/

#### 从网友探秘 《黑神话：悟空》 的脚本说说C#
- 文章简介：从网友探秘 《黑神话：悟空》 的脚本说说C#。
- 文章地址：https://www.cnblogs.com/shanyou/p/18377461

#### 一款基于 .NET Core 框架研发的自媒体内容管理系统
- 文章简介：ShenNiusModularity是一款基于 .NET Core 框架研发的、开源、免费的自媒体内容管理系统。项目秉承大道至简的原则开发，坚持业务模块最低复杂度复用，代码方面追求简单、高效、实用。适合小白入门进阶，同样适用老手上路干活。
- 文章地址：https://mp.weixin.qq.com/s/12wzkzbn7r2cwsfxQgN70A

#### 一款基于.NET8开源的跨平台高性能边缘采集网关
- 文章简介：分享一款基于.NET8开源的跨平台高性能边缘采集网关，提供底层PLC通讯库，通讯调试软件等，单机采集数据点位可达百万：ThingsGateway。
- 文章地址：https://mp.weixin.qq.com/s/iyNdDrKE972C2HXCN3OKUg

#### ASP.NET MVC+LayUI视频上传
- 文章简介：提供了一个完整的ASP.NET MVC+LayUI上传视频的文章教程。
- 文章地址：https://mp.weixin.qq.com/s/7fCEMbHpvkP07FwxqSzCbQ

#### C#/.NET这些实用的编程技巧你都会了吗？
- 文章简介：C#/.NET/.NET Core编程常用语法、算法、技巧、中间件、类库、工作业务实操练习集，配套详细的文章教程讲解，助你快速掌握C#/.NET/.NET Core中各种编程常用语法、算法、技巧、中间件、类库、工作业务实操等等。
- 文章地址：https://mp.weixin.qq.com/s/a9A7w2EhZIoh1AKW8bJzEQ

#### 推荐7款美观且功能强大的WPF UI库
- 文章简介：给大家分享7款开源、美观、功能强大、简单易用的WPF UI组件库。
- 文章地址：https://mp.weixin.qq.com/s/ZKp6qFNDLTuJVse40-h5sQ

#### 使用dnSpyEx对.NET Core程序集进行反编译、编辑和调试
- 文章简介：说到.NET相关的反编译工具大家脑海里第一个想到的工具是什么？ILSpy、dnSpy、还是dotPeek？咱们今天的主要内容是讲讲dnSpyEx（dnSpyEx是dnSpy项目的非官方Fork维护版本）这个开源的.NET程序集反编译、编辑和调试工具该如何使用。
- 文章地址：https://mp.weixin.qq.com/s/KhF6e9yI1ew2A-b0ZZ5Ofw

#### SimpleRAG：基于WPF与Semantic Kernel实现的一个简单的RAG应用
- 文章简介：SimpleRAG是基于WPF与Semantic Kernel实现的一个简单的RAG应用，可用于学习与理解如何使用Semantic Kernel构建RAG应用。
- 文章地址：https://www.cnblogs.com/mingupupu/p/18367726

#### Semantic Kernel/C#：接入智谱AI的两种方式
- 文章简介：Semantic Kernel/C#：接入智谱AI的两种方式
- 文章地址：https://www.cnblogs.com/mingupupu/p/18370917

#### 除了按值和引用，方法参数的第三种传递方式
- 文章简介：参数在方法种具有按“值（by value）”和“引用（by ref）”两种传递方式，这是每个.NET程序员深入骨髓得基本概念。但是我若告诉你，.NET规定的参数传递形式其实是三种，会不会颠覆你的认知。
- 文章地址：https://www.cnblogs.com/artech/p/18374284/typed_reference

#### 方法的三种调用形式
- 文章简介：介绍了.NET方法的三种调用形式。
- 文章地址：https://www.cnblogs.com/artech/p/18363117/method-invocation-dotnet

#### 可以调用Null的实例方法吗？
- 文章简介：前几天有个网友问我一个问题：调用实例方法的时候为什么目标对象不能为Null。看似一个简单的问题，还真不是一句话就能说清楚的。而且这个结论也不对，当我们调用定义在某个类型的实例方法时，目标对象其实可以为Null。
- 文章地址：https://www.cnblogs.com/artech/p/18362421/call_callvirt

### 第 1 期（2024年8.12-8.18）
#### .NET 9 Preview 7现已推出！
- 文章简介：现在是查看最新的.NET 9预览版的好时机！我们刚刚发布了我们的第七个预览版，增加了.NET SDK，库，C#，ASP.NET Core，Blazor和.NET MAUI的一些主要增强功能。查看下面链接的完整发行说明，并立即开始。
- 文章地址：https://devblogs.microsoft.com/dotnet/dotnet-9-preview-7

#### Azure AI Inference SDK简介：使用Azure AI模型目录访问更多AI模型
- 文章简介：发布Azure AI Inference SDK for .NET！此SDK提供了对Azure AI模型目录中的一套全面的AI模型的轻松访问，用于推理任务（如聊天），使您能够轻松地将AI整合到符合您需求的应用程序中。
- 文章地址：https://devblogs.microsoft.com/dotnet/azure-ai-model-catalog-dotnet-inference-sdk

#### .NET和.NET Framework 2024年8月更新
- 文章简介：.NET和.NET Framework 2024年8月的更新摘要。
- 文章地址：https://devblogs.microsoft.com/dotnet/dotnet-and-dotnet-framework-august-2024-updates

#### C#/.NET/.NET Core自学入门指南
- 文章简介：根据自己的学习、开发、工作经验分享一期C#/.NET/.NET Core自学入门指南教程，希望可以帮助到有需要的同学。
- 文章地址：https://mp.weixin.qq.com/s/yY5Znvg6J2FcG5NSIFKBfA

#### C#数据结构与算法实战入门指南
- 文章简介：在编程领域，数据结构与算法是构建高效、可靠和可扩展软件系统的基石。它们对于提升程序性能、优化资源利用以及解决复杂问题具有至关重要的作用。今天大姚分享一些非常不错的C#数据结构与算法实战教程，希望可以帮助到有需要的小伙伴。
- 文章地址：https://mp.weixin.qq.com/s/XPRmwWmoZa4zq29Kx-u4HA

#### 七天.NET 8操作SQLite入门到实战详细教程（选型、开发、发布、部署）
- 文章简介：EasySQLite是一个七天.NET 8操作SQLite入门到实战详细教程（包含选型、开发、发布、部署）！
- 文章地址：https://mp.weixin.qq.com/s/6aKoDIle7nMr2aflMvhdmw

#### 2款.NET开源的加密解密工具类库，值得收藏使用！
- 文章简介：分享2款.NET开源、功能完善的加密解密工具类库，值得大家收藏使用！
- 文章地址：https://mp.weixin.qq.com/s/KnyrIr5d3bXcIJBRYmRQcA

#### 一个.NET开源、免费、跨平台的机器学习框架
- 文章简介：分享一个.NET开源、免费、跨平台（支持Windows、Linux、macOS多个操作系统）的机器学习框架：ML.NET。并且本文将会带你快速使用ML.NET训练一个属于自己的图像分类模型，对图像进行分类。
- 文章地址：https://mp.weixin.qq.com/s/Kr4UgjcbfoXkTEorojAvfA

#### 一款基于.NET8的权限管理及快速开发框架（前后端分离）-YuebonCore
- 文章简介：YuebonCore是一款基于.NET8的权限管理及快速开发框架，支持前后端分离。可以开发 OA、ERP、BPM、CRM、WMS、TMS、MIS、BI、电商平台后台、物流管理系统、快递管理系统、教务管理系统等各类管理软件。
- 文章地址：https://mp.weixin.qq.com/s/z_C4j5NuM8um8NgalhOG9w

#### 使用 Ollama 集成 GraphRag.Net：一步步教你如何实现
- 文章简介：在当今的技术世界，人工智能 (AI) 正在以惊人的速度发展。对于开发者来说，使用最新的工具和框架来提升工作效率至关重要。而在 AI 领域，GraphRag.Net 作为一个强大的图算法框架，允许我们以高效的方式进行数据处理。同样，Ollama 作为一个开源的、简单易用的 AI 模型部署平台，正逐渐受到开发者的青睐。今天，我们就来聊聊如何使用 Ollama 将 GraphRag.Net 进行集成。
- 文章地址：https://mp.weixin.qq.com/s/0EvAkAwN3Zc2TdV0HDNqnA

#### 探索C#中的多线程神器Monitor和Lock
- 文章简介：Monitor、Lock是在 C# 中的多线程应用程序中提供线程安全的方法。两者都提供了一种机制来确保只有一个线程同时执行代码，以避免代码出现线程安全的问题，提高代码的稳定性。它们之间有紧密的联系，本文将通过案例介绍这两者的关系。
- 文章地址：https://mp.weixin.qq.com/s/PzXaBsCbJVV6CxNBJeZzGQ

#### C# AI鉴图宝 利用OCR技术对图片进行是否违规判别
- 文章简介：C# AI鉴图宝 利用OCR技术对图片进行是否违规判别。
- 文章地址：https://mp.weixin.qq.com/s/aDpv5hVgcWd0SFe5m0gHaQ

#### 一个基于 .NET Core 的功能全面、易于使用权限管理系统-YiShaAdmin
- 文章简介：YiShaAdmin是一个功能全面、易于使用的权限管理系统，适合各类Web应用程序的开发与管理。通过其丰富的内置功能和开放的开发文档，开发者可以快速上手并构建高效的管理系统。
- 文章地址：https://mp.weixin.qq.com/s/b4OuLDMBvuAkXzwNL_yoRw

#### .NET 高效Nuget管理工具（开源）
- 文章简介：这是一个Nuget效率工具，用于提升项目与组件间开发过程中的一些重复、流程性问题。如：Nuget包替换为源码引用、修复解决方案下引用Nuget不同版本的问题。
- 文章地址：https://www.cnblogs.com/kybs0/p/18363275

#### 由浅入深理解C#中的事件
- 文章简介：由浅入深理解C#中的事件
- 文章地址：https://mp.weixin.qq.com/s/CeYBNuSmjZjBXUBkqQApZQ


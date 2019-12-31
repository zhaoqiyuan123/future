# 生成EFCode  DBfrist简单使用

===EFCore DBFirst=======

1.点击“工具”->“NuGet包管理器”->“程序包管理器控制台”

Install-Package Microsoft.EntityFrameworkCore
Install-Package Microsoft.EntityFrameworkCore.SqlServer
Install-Package Microsoft.EntityFrameworkCore.Tools
Install-Package Microsoft.VisualStudio.Web.CodeGeneration.Design



##生成实体

Scaffold-DbContext "Data Source=***;database=zrfTempDb;uid=qq;pwd=aoe" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Force

 

参数说明：

-OutputDir *** 实体文件所存放的文件目录
-ContextDir *** DbContext文件存放的目录
-Context *** DbContext文件名
-Schemas *** 需要生成实体数据的数据表所在的模式
-Tables *** 需要生成实体数据的数据表的集合
-DataAnnotations
-UseDatabaseNames 直接使用数据库中的表名和列名（某些版本不支持）
-Force 强制执行，重写已经存在的实体文件
### End

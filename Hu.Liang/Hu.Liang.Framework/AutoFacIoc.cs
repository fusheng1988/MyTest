using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac.Integration.Mvc;
using System.Web.Mvc;
using System.Reflection;
using Hu.Liang.Tools;




namespace Hu.Liang.Framework
{
    public static class AutoFacIoc
    {
        public static void initial()
        {
            //第一步： 构造一个AutoFac的builder容器  
            ContainerBuilder builder = new ContainerBuilder();
            //第二步：告诉AutoFac控制器工厂，控制器类的创建去哪些程序集中查找（默认控制器工厂是去扫描bin目录下的所有程序集）  
            //2.1 从当前运行的bin目录下加载Hu.Liang.MVC程序集
            Assembly controllerAss = Assembly.Load("Hu.Liang.MVC");
            //2.2 告诉AutoFac控制器工厂，控制器的创建从controllerAss中查找（注意：RegisterControllers()方法是一个可变参数，如果你的控制器类的创建需要去多个程序集中查找的话，那么我们就再用Assembly controllerBss=Assembly.Load("需要的程序集名")加载需要的程序集，然后与controllerAss组成数组，然后将这个数组传递到RegisterControllers()方法中）  
            builder.RegisterControllers(controllerAss);

            //第一种注入方式
            //3.1 加载数据仓储层Hu.Liang.Server这个程序集。  
            Assembly repositoryAss = Assembly.Load("Hu.Liang.Server");
            Type[] rtypes = repositoryAss.GetTypes();
            //3.3 告诉AutoFac容器，创建rtypes这个集合中所有类的对象实例  
            builder.RegisterTypes(rtypes).AsImplementedInterfaces(); //指明创建的rtypes这个集合中所有类的对象实例，以其接口的形式保存  
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            //第二种注入方式
            //builder.RegisterType<Hu.Liang.Server.UserServer>().As<Hu.Liang.Interface.IUser>().InstancePerRequest();//用户
            //配合第二种容器注入方式
            //DIContianer.RegisterContainer(container);


        }
    }
}

using MvcMusicStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MvcMusicStore
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //Database.SetInitializer(new DropCreateDatabaseAlways<MusicStoreDB>());//每次运行程序时重新创建数据库。
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<MusicStoreDB>());//每次数据模型发生变化时重新创建数据库
            Database.SetInitializer(new MusicStoreDbInitializer());//调用初始化方法


            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}

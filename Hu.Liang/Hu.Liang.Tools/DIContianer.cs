using Autofac;
using Autofac.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hu.Liang.Tools
{
    public static class DIContianer
    {
        private static IContainer container;
        /// <summary>
        /// 注册DIContainer
        /// </summary>
        /// <param name="container">Autofac.IContainer</param>
        /// <remarks>add by liaojiahua,2015-06-11 19:53:53 </remarks>
        public static void RegisterContainer(IContainer container)
        {
            DIContianer.container = container;
        }
        /// <summary>
        /// 按类型获取组件
        /// </summary>
        /// <typeparam name="T">组件类型</typeparam>
        /// <returns>返回获取的组件</returns>
        /// <remarks>add by liaojiahua,2015-06-13 08:42:26 </remarks>
        public static T Resolve<T>()
        {
            T result;
            using (ILifetimeScope lifetimeScope = DIContianer.container.BeginLifetimeScope())
            {
                result = lifetimeScope.Resolve<T>();
            }
            return result;
        }
        /// <summary>
        /// 按名称获取组件
        /// </summary>
        /// <typeparam name="T">组件类型</typeparam>
        /// <param name="serviceName">组件名称</param>
        /// <returns>返回获取的组件</returns>
        /// <remarks>add by liaojiahua,2015-06-13 08:42:28 </remarks>
        public static T ResolveNamed<T>(string serviceName)
        {
            T result;
            using (DIContianer.container.BeginLifetimeScope())
            {
                result = DIContianer.container.ResolveNamed<T>(serviceName);
            }
            return result;
        }
        /// <summary>
        /// 按参数获取组件
        /// </summary>
        /// <typeparam name="T">组件类型</typeparam>
        /// <param name="parameters"><see cref="T:Autofac.Core.Parameter" /></param>
        /// <returns>返回获取的组件</returns>
        /// <remarks>add by liaojiahua,2015-06-13 08:42:30 </remarks>
        public static T Resolve<T>(params Parameter[] parameters)
        {
            T result;
            using (DIContianer.container.BeginLifetimeScope())
            {
                result = DIContianer.container.Resolve<T>(parameters);
            }
            return result;
        }
        /// <summary>
        /// 按key获取组件
        /// </summary>
        /// <typeparam name="T">组件类型</typeparam>
        /// <param name="serviceKey">枚举类型的Key</param>
        /// <returns>返回获取的组件</returns>
        /// <remarks>add by liaojiahua,2015-06-13 08:42:32 </remarks>
        public static T ResolveKeyed<T>(object serviceKey)
        {
            T result;
            using (DIContianer.container.BeginLifetimeScope())
            {
                result = DIContianer.container.ResolveKeyed<T>(serviceKey);
            }
            return result;
        }
    }
}

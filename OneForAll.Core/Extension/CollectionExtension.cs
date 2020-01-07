using System;
using System.Collections.Generic;
using System.Text;

namespace OneForAll.Core.Extension
{
    /// <summary>
    /// 扩展类：集合
    /// </summary>
    public static class CollectionExtension
    {
        /// <summary>
        /// 遍历
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="list">集合</param>
        /// <param name="action">遍历方法</param>
        public static void ForEach<T>(this IEnumerable<T> list, Action<T> action)
        {
            foreach (var item in list)
            {
                action(item);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OneForAll.Core.Utility
{
    /// <summary>
    /// 帮助类：集合
    /// </summary>
    public static class CollectionHelper
    {
        /// <summary>
        /// 遍历
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="list">集合</param>
        /// <param name="action">遍历方法</param>
        public static void ForEach<T>(IEnumerable<T> list, Action<T> action)
        {
            foreach (var item in list)
            {
                action(item);
            }
        }

        /// <summary>
        /// 查找子级
        /// </summary>
        /// <typeparam name="T">数据类型</typeparam>
        /// <typeparam name="TKey">主键类型</typeparam>
        /// <param name="list">集合</param>
        /// <param name="parent">父级</param>
        /// <param name="deep">是否递归查找</param>
        /// <returns>子级列表</returns>
        public static IEnumerable<T> FindChildren<T, TKey>(
            IEnumerable<T> list,
            T parent,
            bool deep = true) where T : IEntity<TKey>, IParent<TKey>
        {
            var result = new List<T>();
            var children = list.Where(w => w.ParentId.Equals(parent.Id)).ToList();
            if (children.Count > 0)
            {
                result.AddRange(children);
                if (deep)
                {
                    children.ForEach(e =>
                    {
                        var deepChildren = FindChildren<T, TKey>(list, e, deep);
                        if (deepChildren.Count() > 0) result.AddRange(deepChildren);
                    });
                }
            }
            return result;
        }
    }
}

﻿using OneForAll.Core.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
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
            CollectionHelper.ForEach(list, action);
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
            this IEnumerable<T> list,
            T parent,
            bool deep = true) where T : IEntity<TKey>, IParent<TKey>
        {
            return CollectionHelper.FindChildren<T, TKey>(list, parent, deep);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OneForAll.Core
{
    /// <summary>
    /// 接口：树
    /// </summary>
    public interface ITree<TKey> : IEntity<TKey>, IParent<TKey>, IChildren<ITree<TKey>>
    {
    }
}

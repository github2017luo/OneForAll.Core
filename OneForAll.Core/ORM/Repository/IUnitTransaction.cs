using OneForAll.Core;
using System;
using System.Data;

namespace OneForAll.Core.ORM
{
    public interface IUnitTransaction : IDisposable
    {
        bool Commited { get; set; }
        void Register<T>(Func<int> action, T conn);
        int Commit(TransactionType tranType = TransactionType.Local);

        void RollBack();
    }
}

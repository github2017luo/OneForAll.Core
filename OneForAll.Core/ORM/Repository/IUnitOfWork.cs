using System;
using System.Collections.Generic;

namespace OneForAll.Core.ORM
{

    public interface IUnitOfWork : IDisposable
    {
        HashSet<Exception> Exceptions { get; set; }

        IUnitTransaction BeginTransaction();

        int Commit();

        void RollBack();

    }
}

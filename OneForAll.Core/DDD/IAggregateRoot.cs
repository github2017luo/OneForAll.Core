using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OneForAll.Core.DDD
{
    public interface IAggregateRoot<TType>
    {
        TType Id { get; set; }
    }
}

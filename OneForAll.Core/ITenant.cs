using System;
using System.Collections.Generic;
using System.Text;

namespace OneForAll.Core
{
    public interface ITenant<TType>
    {
        TType TenantId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OneForAll.Core
{
    public interface ICreator<TType>
    {
        TType CreatorId { get; set; }

        string CreatorName { get; set; }
    }
}

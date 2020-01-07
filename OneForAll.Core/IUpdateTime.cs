using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace OneForAll.Core
{
    public interface IUpdateTime
    {
        DateTime? UpdateTime { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugFlow.Domain
{
    public enum BugStatus
    {
        OPEN = 1,
        ASSIGNED = 2,
        CHANGED = 3,
        RESOLVED = 4,
        CLOSED = 5
    }   
}

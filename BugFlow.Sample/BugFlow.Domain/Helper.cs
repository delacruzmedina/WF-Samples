using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugFlow.Domain
{
    public class Helper
    {
        public static BugStatus ConvertBugStatus(int bugStatusId)
        {
            switch (bugStatusId)
            {
                case 1:
                    return BugStatus.OPEN;
                case 2:
                    return BugStatus.ASSIGNED;
                case 3:
                    return BugStatus.CHANGED;
                case 4:
                    return BugStatus.RESOLVED;
                case 5:
                    return BugStatus.CLOSED;
                default:
                    return BugStatus.OPEN;
            }
        }
    }
}

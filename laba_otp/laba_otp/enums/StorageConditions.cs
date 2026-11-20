using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otp_lab_25
{
    [Flags]
    public enum StorageConditions
    {
        None = 0,
        Dry = 1,
        Dark = 2,
        Cool = 4,
        Refrigerated = 8,
        Freezer = 16
    }
}

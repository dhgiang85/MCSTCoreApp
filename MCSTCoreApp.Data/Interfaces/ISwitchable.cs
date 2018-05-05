using System;
using System.Collections.Generic;
using System.Text;
using MCSTCoreApp.Data.Enums;

namespace MCSTCoreApp.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { set; get; }
    }
}

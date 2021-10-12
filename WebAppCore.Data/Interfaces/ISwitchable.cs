using System;
using System.Collections.Generic;
using System.Text;
using WebAppCore.Data.Enums;

namespace WebAppCore.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { set; get; }
    }
}

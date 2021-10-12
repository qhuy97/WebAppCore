using System;
using System.Collections.Generic;
using System.Text;

namespace WebAppCore.Data.Interfaces
{
    public interface IHasSoftDelete
    {
        bool IsDeleted { set; get; }

    }
}

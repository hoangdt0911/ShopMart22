using ShopMart22.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopMart22.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { set; get; }
    }
}

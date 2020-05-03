using System;
using System.Collections.Generic;
using System.Text;

namespace ShopMart22.Data.Interfaces
{
    public interface IDateTracking
    {
        DateTime DateCreated { set; get; }

        DateTime DateModified { set; get; }
    }
}

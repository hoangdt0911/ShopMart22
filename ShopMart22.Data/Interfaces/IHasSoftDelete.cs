using System;
using System.Collections.Generic;
using System.Text;

namespace ShopMart22.Data.EF.Configurations
{
    public interface IHasSoftDelete
    {
        bool IsDeleted { set; get; }
    }
}

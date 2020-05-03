using System;
using System.Collections.Generic;
using System.Text;

namespace ShopMart22.Data.Interfaces
{
    public interface IMultiLanguage<T>
    {
        T LanguageId { set; get; }
    }
}

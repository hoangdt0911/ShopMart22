using ShopMart22.Application.ViewModels.Product;
using ShopMart22.Utilities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopMart22.Application.Interfaces
{
    public interface IProductService : IDisposable
    {
        List<ProductViewModel> GetAll();

        PagedResult<ProductViewModel> GetAllPaging(int? categoryId, string keyword, int page, int pageSize);

        ProductViewModel Add(ProductViewModel productVm);

        void Update(ProductViewModel product);

        void Delete(int id);

        ProductViewModel GetById(int id);

        void Save();
    }
}

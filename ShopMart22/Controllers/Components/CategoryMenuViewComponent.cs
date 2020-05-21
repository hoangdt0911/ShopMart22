using Microsoft.AspNetCore.Mvc;
using ShopMart22.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopMart22.Controllers.Components
{
    public class CategoryMenuViewComponent : ViewComponent
    {
        private IProductCategoryService _productCategoryService;
        //private IMemoryCache _memoryCache;
        public CategoryMenuViewComponent(IProductCategoryService productCategoryService)
        {
            _productCategoryService = productCategoryService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            //var categories = _memoryCache.GetOrCreate(CacheKeys.ProductCategories, entry => {
            //    entry.SlidingExpiration = TimeSpan.FromHours(2);
            //    return _productCategoryService.GetAll();
            //});

            return View(_productCategoryService.GetAll());
        }
    }
}

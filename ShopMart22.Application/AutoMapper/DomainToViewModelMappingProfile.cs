using AutoMapper;
using ShopMart22.Application.ViewModels.Product;
using ShopMart22.Application.ViewModels.System;
using ShopMart22.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopMart22.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ProductCategory, ProductCategoryViewModel>();

            CreateMap<Product, ProductViewModel>();

            CreateMap<Function, FunctionViewModel>();

            CreateMap<AppUser, AppUserViewModel>();

            CreateMap<AppRole, AppRoleViewModel>();
        }
    }
}

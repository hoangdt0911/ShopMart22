using ShopMart22.Data.Entities;
using ShopMart22.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopMart22.Data.EF.Repositories
{
    public class ProductRepository : EFRepository<Product, int>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {

        }
    }
}

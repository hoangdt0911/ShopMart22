using ShopMart22.Data.Entities;
using ShopMart22.Data.IRepositories;

namespace ShopMart22.Data.EF.Repositories
{
    public class ProductTagRepository : EFRepository<ProductTag,int>, IProductTagRepository
    {
        public ProductTagRepository(AppDbContext context) : base(context)
        {
            
        }
    }
}

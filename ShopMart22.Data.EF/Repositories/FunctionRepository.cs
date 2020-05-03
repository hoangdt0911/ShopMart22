using ShopMart22.Data.Entities;
using ShopMart22.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopMart22.Data.EF.Repositories
{
    public class FunctionRepository : EFRepository<Function,string>, IFunctionRepository
    {
        public FunctionRepository(AppDbContext context) : base(context)
        {

        }
    }
}

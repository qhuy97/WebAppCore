using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebAppCore.Data.Entities;
using WebAppCore.Data.IRespositories;

namespace WebAppCore.Data.EF.Repositories
{
    public class ProductCategoryRepository : EFRepository<ProductCategory, int>, IProductCategoryRepository
    {
        AppDbContext _Context;
        public ProductCategoryRepository(AppDbContext context) :base(context)
        {
            _Context = context;
        }
        public List<ProductCategory> GetByAlias(string alias)
        {
            return _Context.ProductCategories.Where(x => x.SeoAlias == alias).ToList();
        }
    }
}

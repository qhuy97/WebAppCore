using System;
using System.Collections.Generic;
using System.Text;
using WebAppCore.Data.Entities;
using WebAppCore.Infrastructure.Interfaces;

namespace WebAppCore.Data.IRespositories
{
    public interface IProductCategoryRepository : IRepository<ProductCategory,int>
    {
        List<ProductCategory> GetByAlias(string alias);
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MCSTCoreApp.Data.Entities;
using MCSTCoreApp.Data.IRepositories;

namespace MCSTCoreApp.Data.FF.Repositories
{
    public class ProductCategoryRepository : EFRepository<ProductCategory, int>, IProductCategoryRepository
    {
        AppDbContext _context;
        public ProductCategoryRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public List<ProductCategory> GetByAlias(string alias)
        {
            return _context.ProductCategories.Where(x => x.SeoAlias == alias).ToList();
        }
    }
}

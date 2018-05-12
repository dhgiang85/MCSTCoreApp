using MCSTCoreApp.Data.Entities;
using MCSTCoreApp.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MCSTCoreApp.Data.IRepositories
{
    public interface IBlogTagRepository : IRepository<BlogTag, int>
    {
    }
}

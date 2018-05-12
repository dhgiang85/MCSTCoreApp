using MCSTCoreApp.Data.Entities;
using MCSTCoreApp.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MCSTCoreApp.Data.IRepositories
{
    public interface IBlogRepository : IRepository<Blog, int>
    {
    }
}

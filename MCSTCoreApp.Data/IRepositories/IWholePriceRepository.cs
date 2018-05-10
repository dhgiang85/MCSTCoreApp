using System;
using System.Collections.Generic;
using System.Text;
using MCSTCoreApp.Data.Entities;
using MCSTCoreApp.Infrastructure.Interfaces;

namespace MCSTCoreApp.Data.IRepositories
{
    public interface IWholePriceRepository : IRepository<WholePrice, int>
    {
    }
}

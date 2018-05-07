using System;
using System.Collections.Generic;
using System.Text;
using MCSTCoreApp.Application.ViewModels.Product;
using MCSTCoreApp.Utilities.Dtos;

namespace MCSTCoreApp.Application.Interfaces
{
    public interface IProductService : IDisposable
    {
        List<ProductViewModel> GetAll();
        PagedResult<ProductViewModel> GetAllPaging(int? categoryId, string keyword, int page, int pageSize);
    }
}

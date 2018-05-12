using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MCSTCoreApp.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MCSTCoreApp.Controllers.Components
{
    public class MobileMenuViewComponent : ViewComponent
    {

        private IProductCategoryService _productCategoryService;

        public MobileMenuViewComponent(IProductCategoryService productCategoryService)
        {
            _productCategoryService = productCategoryService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = _productCategoryService.GetAll();
            return View(model);
        }
    }
}

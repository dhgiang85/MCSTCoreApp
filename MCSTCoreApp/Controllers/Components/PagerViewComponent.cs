﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MCSTCoreApp.Utilities.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace MCSTCoreApp.Controllers.Components
{
    public class PagerViewComponent : ViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(PagedResultBase result)
        {
            return Task.FromResult((IViewComponentResult)View("Default", result));
        }
    }
}

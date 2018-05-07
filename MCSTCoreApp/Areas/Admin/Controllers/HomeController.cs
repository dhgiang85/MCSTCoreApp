﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MCSTCoreApp.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MCSTCoreApp.Areas.Admin.Controllers
{

    public class HomeController : BaseController
    {

        public IActionResult Index()
        {
            var email = User.GetSpecificClaim("Email");
            return View();
        }
    }
}
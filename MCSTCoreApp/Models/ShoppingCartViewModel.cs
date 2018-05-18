﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MCSTCoreApp.Application.ViewModels.Product;

namespace MCSTCoreApp.Models
{
    public class ShoppingCartViewModel
    {
        public ProductViewModel Product { set; get; }

        public int Quantity { set; get; }

        public decimal Price { set; get; }

        public int ColorId { get; set; }

        public int SizeId { get; set; }
    }
}

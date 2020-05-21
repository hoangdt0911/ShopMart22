﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ShopMart22.Application.ViewModels.Product
{
    public class WholePriceViewModel
    {
        public int ProductId { get; set; }

        public int FromQuantity { get; set; }

        public int ToQuantity { get; set; }

        public decimal Price { get; set; }
    }
}
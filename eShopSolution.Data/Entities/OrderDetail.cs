﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class OrderDetail
    {
        public int OrderId { set; get; }
        public int ProductId { set; get; }
        public decimal Price { set; get; }
        public int Quantity { set; get; }
        public Order Order { set; get; }
        public Product Product { set; get; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo002.Models
{
    public class CartItem
    {
        public CartItem()
        {
            
        }

        public CartItem(Product product, int quantity)
        {
            this.ProductId = product.Id;
            this.ProductName = product.Name;
            this.UnitPrice = product.Price;
            this.Quantity = quantity;
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
    }
}
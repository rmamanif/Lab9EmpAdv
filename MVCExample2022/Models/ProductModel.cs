﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCExample2022.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }
}
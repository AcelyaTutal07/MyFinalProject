﻿
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities

{
    public class  ProductDetailDto: IDto // evrensel bir interface

    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public short UnitsInStock { get; set; }
       


    }
}

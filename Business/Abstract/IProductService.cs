﻿using Core.Entities;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
     public interface IProductService

    {

        IDataResult<List<Product>> GetAll(); //içinde bir data koymak istediğimiz için
        IDataResult<List<Product>> GetAllByCategoryId(int Id);
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IDataResult<Product> GetById(int productId);
        IResult Add(Product product); //void döndürme
        IResult Update(Product product);
        IResult AddTransactionalTest(Product product);
    }
}

﻿using Core.DataAccess.EntityFramewok;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
  public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal     
    {

    }

   
}

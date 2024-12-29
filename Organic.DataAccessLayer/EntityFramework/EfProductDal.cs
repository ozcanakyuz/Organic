﻿using Organic.DataAccessLayer.Abstract;
using Organic.DataAccessLayer.Context;
using Organic.DataAccessLayer.Repositories;
using Organic.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organic.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public EfProductDal(OrganicContext context) : base(context)
        {
        }
    }
}

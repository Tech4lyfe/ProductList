﻿using AngularProductList.WebAPI.Models;
using APM.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AngularProductList.WebAPI.Controllers
{
    public class ProductsController : ApiController
    {
        ProductRepository repo = new ProductRepository();
        // GET: api/Products
        public IEnumerable<Product> Get()
        {
          return  repo.Retrieve();
        }

        // GET: api/Products/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Products
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Products/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Products/5
        public void Delete(int id)
        {
        }
    }
}

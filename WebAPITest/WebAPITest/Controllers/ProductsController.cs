using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPITest.Models;

namespace WebAPITest.Controllers
{
    public class ProductsController : ApiController
    {
        private sample_dbEntities db = new sample_dbEntities();
        private IQueryable<ProductDTO> MapProducts()
        {
            return from p in db.Products
                   select new ProductDTO() { Id = p.Id, Name = p.Name, Price = Convert.ToDecimal(p.price) };
        }

        public ProductDTO GetProduct(int id)
        {
            var product = (from p in MapProducts()
                           where p.Id == 1
                           select p).FirstOrDefault();
            if (product == null)
            {
                throw new HttpResponseException(
                    Request.CreateResponse(HttpStatusCode.NotFound));
            }
            return product;
        }
    }
}

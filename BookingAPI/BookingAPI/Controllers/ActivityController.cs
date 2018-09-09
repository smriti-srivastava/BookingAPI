using BookingAPI.Entities;
using BookingAPI.RepositoryLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BookingAPI.Controllers
{
    public class ActivityController : ApiController
    {
        [Route("Products/Activity")]
        [HttpPost]
        public void AddAirProduct(Activity airProduct)
        {
            ActivityProductRepository repository = new ActivityProductRepository();
            repository.AddProduct(airProduct);
        }

        [Route("Products/Activity")]
        [HttpGet]
        public List<Activity> Get()
        {
            ActivityProductRepository repository = new ActivityProductRepository();
            return repository.GetAllProducts();
        }

        [Route("Products/Activity/Book/{id}")]
        [HttpPut]
        public bool BookProdcut([FromUri]int id)
        {
            ActivityProductRepository repository = new ActivityProductRepository();
            return repository.BookProduct(id);
        }

        [Route("Products/Activity/Save/{id}")]
        [HttpPut]
        public void SaveProduct([FromUri]int id)
        {
            ActivityProductRepository repository = new ActivityProductRepository();
            repository.SaveProduct(id);
        }
    }
}
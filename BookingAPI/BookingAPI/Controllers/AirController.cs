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
    public class AirController : ApiController
    {
        [Route("Products/Air")]
        [HttpPost]
        public void AddAirProduct(Air airProduct)
        {
            AirProductRepository repository = new AirProductRepository();
            repository.AddProduct(airProduct);
        }

        [Route("Products/Air")]
        [HttpGet]
        public List<Air> Get()
        {
            AirProductRepository repository = new AirProductRepository();
            return repository.GetAllProducts();
        }

        [Route("Products/Air/Book/{id}")]
        [HttpPut]
        public bool BookProdcut([FromUri]int id)
        {
            AirProductRepository repository = new AirProductRepository();
            return repository.BookProduct(id);
        }

        [Route("Products/Air/Save/{id}")]
        [HttpPut]
        public void SaveProduct([FromUri]int id)
        {
            AirProductRepository repository = new AirProductRepository();
            repository.SaveProduct(id);
        }
    }
}
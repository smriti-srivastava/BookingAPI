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
    public class CarController : ApiController
    {
        [Route("Products/Car")]
        [HttpPost]
        public void AddProduct(Car carProduct)
        {
            CarProductRepository repository = new CarProductRepository();
            repository.AddProduct(carProduct);
        }

        [Route("Products/Car")]
        [HttpGet]
        public List<Car> Get()
        {
            CarProductRepository repository = new CarProductRepository();
            return repository.GetAllProducts();
        }

        [Route("Products/Car/Book/{id}")]
        [HttpPut]
        public bool BookProduct([FromUri]int id)
        {
            CarProductRepository repository = new CarProductRepository();
            return repository.BookProduct(id);
        }

        [Route("Products/Car/Save/{id}")]
        [HttpPut]
        public void SaveProduct([FromUri]int id)
        {
            CarProductRepository repository = new CarProductRepository();
            repository.SaveProduct(id);
        }
    }
}
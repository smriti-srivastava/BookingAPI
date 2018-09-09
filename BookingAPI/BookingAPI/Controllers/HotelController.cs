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
    public class HotelController : ApiController
    {
        [Route("Products/Hotel")]
        [HttpPost]
        public void AddProduct(Hotel hotelProduct)
        {
            HotelProductRepository repository = new HotelProductRepository();
            repository.AddProduct(hotelProduct);
        }

        [Route("Products/Hotel")]
        [HttpGet]
        public List<Hotel> Get()
        {
            HotelProductRepository repository = new HotelProductRepository();
            return repository.GetAllProducts();
        }

        [Route("Products/Hotel/Book/{id}")]
        [HttpPut]
        public bool BookProduct([FromUri]int id)
        {
            HotelProductRepository repository = new HotelProductRepository();
            return repository.BookProduct(id);
        }

        [Route("Products/Hotel/Save/{id}")]
        [HttpPut]
        public void SaveProduct([FromUri]int id)
        {
            HotelProductRepository repository = new HotelProductRepository();
            repository.SaveProduct(id);
        }
    }
}
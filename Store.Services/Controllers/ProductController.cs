using Store.Models;
using Store.Services.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace Store.Services.Controllers
{
    public class ProductController : ApiController
    {
        private readonly StoreDBContext db;
        public ProductController()
        {
            db = new StoreDBContext();
        }

        [HttpGet]
        public IHttpActionResult AllProducts()
        {
            var list = new List<Product>();
            list = db.Products.ToList();
            return Ok(list);
        }

        [HttpGet]
        public IHttpActionResult GetById(int id)
        {
            var entity = db.Products.Find(id);
            return Ok(entity);
        }

        [HttpPost]
        public IHttpActionResult Post(Product obj)
        {
            db.Products.Add(obj);
            db.SaveChanges();
            return Ok(obj);
        }

        [HttpGet]
        public IHttpActionResult GetCountriesNames()
        {
            var list = new List<Country>();
            list = db.Countries.ToList();
            return Ok(list);
        }

        [HttpGet]
        public IHttpActionResult GetCategoriesNames()
        {
            var list = new List<Category>();
            list = db.Categories.ToList();
            return Ok(list);
        }

        
    }
}
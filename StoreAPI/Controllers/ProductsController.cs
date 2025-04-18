using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using StoreAPI.Models;


namespace StoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public static List<Product> _products = new List<Product>();
    }
}

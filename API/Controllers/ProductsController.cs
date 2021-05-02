//using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using System.Linq;
//using API.Dtos;
//using API.Errors;
//using API.Helpers;
//using AutoMapper;
//using Core.Entities;
//using Core.Interfaces;
//using Core.Specifications;
//using Infrastructure.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Infrastructure.Data;
using Core.Entities;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly StoreContext _context;
        public ProductsController(StoreContext context)
        {
            _context = context;
        }

/*
        [HttpGet]
        public ActionResult<List<Product>> GetProducts()
        {
            var products = _context.Products.ToList();
            return Ok(products);
        }
*/
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            var products = await _context.Products.ToListAsync();
            return Ok(products);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<List<Product>>> GetProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            return Ok(product);
        }


    }
}
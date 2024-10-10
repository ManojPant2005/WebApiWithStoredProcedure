using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiWithStoredProcedure.Data.Entities;
using WebApiWithStoredProcedure.Service;

namespace WebApiWithStoredProcedure.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController(IProduct _product) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Product product)
        {
            await _product.InsertProduct(product);
            return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetAll()
        {
            return Ok(await _product.GetAllProducts());     
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Product>> GetById(int id)
        {
            return Ok(await _product.GetProductById(id));
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] Product product)
        {
            await _product.UpdateProduct(product);
            return NoContent();     
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _product.DeleteProduct(id);
            return NoContent();     
        }
    }
}

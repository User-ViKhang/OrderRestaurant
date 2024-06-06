using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RestaurentAPI.Data;
using RestaurentAPI.Data.Entities;
using RestaurentAPI.Models;
using RestaurentAPI.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestaurentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class ItemController : ControllerBase
    {
        private readonly IItemService _itemService;

        public ItemController(IItemService itemService)
        {
            _itemService = itemService;
        }

        // GET: api/<ItemController>
        [HttpGet]
        public IActionResult Get()
        {
            if (!ModelState.IsValid) return BadRequest();
            var result = _itemService.GetItems();
            return Ok(result);
        }

        // GET api/<ItemController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ItemController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ItemController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ItemController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

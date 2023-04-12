using HybridConnectionsTest.Models;
using HybridConnectionsTest.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HybridConnectionsTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {

        private readonly BooksService _booksService;

        public BooksController(BooksService booksService) =>
            _booksService = booksService;


        // GET: api/<MongoDbController>

        [HttpGet]
        public async Task<List<Books>> Get() =>
            await _booksService.GetAsync();



        // GET api/<MongoDbController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MongoDbController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MongoDbController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MongoDbController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

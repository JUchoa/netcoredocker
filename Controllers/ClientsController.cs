using System.Linq;  
using Microsoft.AspNetCore.Mvc;
using netcoredocker.Models;

namespace netcoredocker.Controllers
{
    public class ClientsController : ControllerBase
    {
        private readonly ApiContext _context;

        public ClientsController(ApiContext context)
        {
            _context = context;
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            var model = _context.Clients.ToList();

            return Ok(new { Products = model });
        }

         [HttpPost]
        public IActionResult Create([FromBody]Client model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _context.Clients.Add(model);
            _context.SaveChanges();

            return Ok(model);
        }

         [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody]Client model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var client = _context.Clients.Find(id);

            if (client == null)
            {
                return NotFound();
            }

            client.Name = model.Name;

            _context.SaveChanges();

            return Ok(client);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var client = _context.Clients.Find(id);

            if (client == null)
            {
                return NotFound();
            }

            _context.Remove(client);
            _context.SaveChanges();

            return Ok(client);
        }
    }
}
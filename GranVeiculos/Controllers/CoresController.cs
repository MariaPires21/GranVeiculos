using System.Threading.Tasks;
using GranVeiculos.Data;
using Microsoft.AspNetCore.Mvc;
using GranVeiculos.Models;
using System.Reflection.Metadata.Ecma335;

namespace GranVeiculos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class CoresController(AppDbContext db) : ControllerBase
    {

        private readonly AppDbContext _db = db;

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_db.Cores.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var cor = _db.Cores.Find(id);
            if (cor == null)
            {
                return NotFound();
            }
            return Ok(cor);

        }

        [HttpPost]
        public IActionResult Create([FromBody] Cor cor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Cor inválida");
            }
            _db.Cores.Add(cor);
            _db.SaveChanges();  

            return CreatedAtAction (nameof(Get), cor.Id, new { cor });


        }      
        [HttpPut("{id}")] 
        public IActionResult Update(int id, [FromBody] Cor cor)
        {
            if (!ModelState.IsValid || id != cor.Id)
            {
                return BadRequest("Cor inválida");
            }
            
        }
    }
}
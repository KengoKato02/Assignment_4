using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Assignment_4.Managers;
using MandaAssig_1;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Assignment_4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FootballPlayerController : ControllerBase
    {
        private readonly FootballPlayerManager _manager = new FootballPlayerManager();
        // GET: api/<ValuesController>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IEnumerable<FootballPlayer> Get()
        {
            return _manager.GetAll();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public FootballPlayer Get(int id)
        {
            return _manager.GetByID(id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public FootballPlayer Post([FromBody] FootballPlayer value)
        {
            return _manager.Add(value);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public FootballPlayer Put(int id, [FromBody] FootballPlayer value)
        {
            return _manager.Update(id, value);
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public FootballPlayer Delete(int id)
        {
            return _manager.Delete(id);
        }
    }
}

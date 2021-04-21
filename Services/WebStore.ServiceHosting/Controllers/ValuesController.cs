using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.ServiceHosting.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private static readonly List<string> __Values = Enumerable
            .Range(1, 10)
            .Select(x => $"Value-{x:00}")
            .ToList();

        [HttpGet] //http://Localhost:5001/api/values
        public IEnumerable<string> Get() => __Values;

        //public ActionResult<IEnumerable<string>> Get() => __Values;

        [HttpGet("{id}")] //http://Localhost:5001/api/values/5
        public ActionResult<string> Get(int id)
        {
            if (id < 0)
                return BadRequest();
            if (id >= __Values.Count)
                return NotFound();

            return __Values[id];
        }

        [HttpPost]         //http://Localhost:5001/api/values
        [HttpPost("add")]  //http://Localhost:5001/api/values/add
        public  ActionResult Post([FromBody] string Str)
        {
            __Values.Add(Str);

            return CreatedAtAction(nameof(Get), new { id = __Values.Count - 1 }); //http://Localhost:5001/api/values/10
        }

        [HttpPut("{id}")] //http://Localhost:5001/api/values/5
        [HttpPut("edit/{id}")]  //http://Localhost:5001/api/values/edit/5
        public ActionResult Put(int id,[FromBody] string Str)
        {
            if (id < 0)
                return BadRequest();
            if (id >= __Values.Count)
                return NotFound();

            __Values[id] = Str;

            return Ok();

        }
        [HttpDelete("{id}")] //http://Localhost:5001/api/values/5
        public ActionResult Delete(int id)
        {
            if (id < 0)
                return BadRequest();
            if (id >= __Values.Count)
                return NotFound();

            __Values.RemoveAt(id);

            return Ok();

        }


    }
}

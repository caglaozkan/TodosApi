using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        TodoContext dataContext ;
        public ValuesController (TodoContext dbcontext)
        {
            dataContext = dbcontext;
        }
        // GET api/values
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(dataContext.TodoItems.ToList());
        }

        // GET api/values/5
        [Route("[action]")]
        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(dataContext.TodoItems.Where(x=>x.Id==id).FirstOrDefault());
            
        }

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Kisiler kisi)
        {
            try
            {
               dataContext.TodoItems.Add(kisi) ;
               dataContext.SaveChanges();
               return Ok();
            }
            catch (System.Exception ex)
            {
                
               return BadRequest(ex);
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

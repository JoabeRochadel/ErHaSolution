using System.Collections.Generic;
using System.Threading.Tasks;
using ErHaSolution.Models;
using Microsoft.AspNetCore.Mvc;

namespace ErHaSolution.Controllers
{
    [Route("employee")]
    public class EmployeeCategoryController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<EmployeeCategory>>> FindAll()
        {
            return new List<EmployeeCategory>();
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<EmployeeCategory>> FindById(int id)
        {
            return new EmployeeCategory();
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<List<EmployeeCategory>>> Post([FromBody]EmployeeCategory category)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(category);
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<ActionResult<List<EmployeeCategory>>> Put(int id, [FromBody]EmployeeCategory category)
        {
            if (category.Id != id)
            {
                return NotFound(new { message = "Categoria não encontrada" });
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(category);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult<List<EmployeeCategory>>> Delete(int id)
        {
            return Ok();
        }

    }
}

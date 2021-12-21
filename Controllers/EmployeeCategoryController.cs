using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ErHaSolution.Data;
using ErHaSolution.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ErHaSolution.Controllers
{
    [Route("employee")]
    public class EmployeeCategoryController : ControllerBase
    {
        private readonly DataContext _context;

        public EmployeeCategoryController( DataContext context )
        {
            _context = context;
        }
        
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<EmployeeCategory>>> FindAll()
        {
            var categories = await _context.EmployeeCategories.AsNoTracking().ToListAsync();
            if (categories == null)
            {
                NotFound();
            }
            return categories;
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<EmployeeCategory>> FindById(int id)
        {
            var category = await _context.EmployeeCategories.FirstOrDefaultAsync(p => p.Id.Equals(id));
            if (category == null)
            {
                NotFound();
            }
            return category;
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

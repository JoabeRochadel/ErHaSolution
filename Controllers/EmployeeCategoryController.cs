using System.Collections.Generic;
using System.Threading.Tasks;
using ErHaSolution.Data;
using ErHaSolution.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ErHaSolution.Controllers
{
    [Route("EmployeeCategory")]
    public class EmployeeCategoryController : ControllerBase
    {

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<EmployeeCategory>>> SelecionarTodos([FromServices] DataContext context)
        {
            try
            {
                var categories = await context.EmployeeCategories.AsNoTracking().ToListAsync();
                if (categories == null)
                {
                    NotFound();
                }
                return categories;
            }

            catch
            {
                return BadRequest(new { message = "Erro ao consultar categoria" });
            }
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<EmployeeCategory>> SelecionarPorId([FromServices] DataContext context, int id)
        {
            try
            {
                var category = await context.EmployeeCategories.AsNoTracking()
                    .FirstOrDefaultAsync(p => p.Id.Equals(id));
                if (category == null)
                {
                    NotFound();
                }

                return category;
            }
            catch
            {
                return BadRequest(new { message = "Erro ao consultar categoria" });
            }
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<List<EmployeeCategory>>> InserirCategoria(
                    [FromBody] EmployeeCategory category,
                    [FromServices] DataContext context)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                context.EmployeeCategories.Add(category);
                await context.SaveChangesAsync();
                return Ok(category);
            }
            catch
            {
                return BadRequest(new { message = "Erro ao criar categoria" });
            }
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<ActionResult<List<EmployeeCategory>>> AtualizarCategoria(int id,
                        [FromBody] EmployeeCategory category,
                        [FromServices] DataContext context)
        {

            if (category.Id != id)
            {
                return NotFound(new { message = "Categoria não encontrada" });
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

        
            try
            {
                context.Entry<EmployeeCategory>(category).State = EntityState.Modified;
                await context.SaveChangesAsync();
                return Ok(category);

            }
            catch
            {
                return BadRequest(new { message = "Erro ao atualizar categoria" });
            }
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult<List<EmployeeCategory>>> DeletarCategoria(int id)
        {
            try
            {
                return Ok();
            }
            catch
            {
                return BadRequest(new { message = "Erro ao deletar categoria" });
            }

        }

    }
}
